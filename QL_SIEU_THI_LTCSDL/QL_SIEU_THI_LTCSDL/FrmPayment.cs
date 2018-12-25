using System;
using System.Data;
using System.Linq;
using System.Data.Linq;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace QL_SIEU_THI_LTCSDL
{
    public partial class FrmPayment : DevExpress.XtraEditors.XtraForm
    {
        private FilterInfoCollection CaptureDevice;

        private VideoCaptureDevice FinalFrame;
        //private bool isEnableScanner = true;

        private Table<tbl_Product> tbl_Product;
        private Table<tbl_Bill> tbl_Bill;
        private DatabaseDataContext db;

        //Bill
        private DataTable dt;
        
        public FrmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();
            tbl_Product = db.tbl_Products;
            tbl_Bill = db.tbl_Bills;

            LoadListProductDatabaseToDataGridView();

            dt = new DataTable();
            dt.Columns.Add("ProductID");
            dt.Columns.Add("NameOfProduct");
            dt.Columns.Add("NumberOfProduct");
            dt.Columns.Add("PriceOfProduct");
            dgvBill.DataSource = dt;

            loadBarCode();
        }
        
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void loadBarCode()
        {
            timer1.Enabled = true;
            timer1.Start();

            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            FinalFrame = new VideoCaptureDevice();

            FinalFrame = new VideoCaptureDevice(CaptureDevice[0].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }

        private void LoadListProductDatabaseToDataGridView()
        {
            dgvProduct.DataSource = tbl_Product;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            tbl_Product product = null;

            try
            {
                product = db.tbl_Products.FirstOrDefault(res => res.ProductID.Equals(txtProductID.Text));
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Nhập ID sản phẩm", "Thông báo");
                return;
            }

            if (product == null)
            {
                XtraMessageBox.Show("Không tìm thấy hàng hóa", "Thông báo");
                return;
            }

            //Kiem tra trong bill da co hang hoa giong 
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[0].Equals(txtProductID.Text))
                {
                    int numberOfProduct = int.Parse(dr[2].ToString());
                    dr[2] = (++numberOfProduct).ToString();
                    dgvBill.DataSource = dt;
                    return;
                }
            }

            DataRow ndr = dt.NewRow();
            ndr[0] = txtProductID.Text;
            ndr[1] = product.NameOfProduct;
            ndr[2] = txtNumberOfProduct.Text;
            ndr[3] = product.PriceOfProduct;

            dt.Rows.Add(ndr);
            dgvBill.DataSource = dt;
            txtNumberOfProduct.Text = "1";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)pictureBox1.Image);
            try
            {
                //Loai barcode giong nhau gan nhat
                //if (!isEnableScanner) return;

                string decoded = result.ToString().Trim();
                if (decoded.Equals(txtProductID.Text))
                {
                    int numberOfProduct = int.Parse(txtNumberOfProduct.Text);
                    txtNumberOfProduct.Text = (++numberOfProduct).ToString();
                }
                txtProductID.Text = decoded;
                timer1.Start();

                //isEnableScanner = false;
            }
            catch (Exception)
            {
                //isEnableScanner = true;
                timer1.Start();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_Bill bill = new tbl_Bill();
                bill.AdminID = SessionInfo.adminID;
                bill.BilledDate = int.Parse(DateTime.Today.ToString("yyyyMMdd"));
                bill.CustomerID = int.Parse(txtCustomerID.Text);
                tbl_Bill.InsertOnSubmit(bill);

                db.SubmitChanges();

                tbl_Bill curBill = db.tbl_Bills.OrderByDescending(res => res.BillID).FirstOrDefault();

                foreach (DataRow dr in dt.Rows)
                {
                    tbl_DetailedBill detailedBill = new tbl_DetailedBill();
                    detailedBill.IDBill = curBill.BillID;
                    detailedBill.IDProduct = int.Parse(dr[0].ToString());
                    detailedBill.UnitPrice = int.Parse(dr[3].ToString());
                    detailedBill.Amount = int.Parse(dr[2].ToString());
                    db.tbl_DetailedBills.InsertOnSubmit(detailedBill);
                }

                db.SubmitChanges();
                XtraMessageBox.Show("Thanh toán thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Thanh toán thất bại" + ex.Message, "Thông báo");
            }
        }

        private void dgvBill_ProcessGridKey(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            var grid = sender as GridControl;
            var view = grid.FocusedView as GridView;
            if (e.KeyData == Keys.Delete)
            {
                view.DeleteSelectedRows();
                e.Handled = true;
            }
        }

        private void txtCustomerID_Enter(object sender, EventArgs e)
        {

        }

        private void txtCustomerID_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                tbl_Customer customer = db.tbl_Customers.FirstOrDefault(res => res.CustomerID.ToString().Equals(txtCustomerID.Text));
                lblNameOfCustomer.Text = customer.NameOfCustomer;
                lblTelOfCustomer.Text = customer.TelOfCustomer;
            }
            catch(Exception)
            { }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dgvBill.DataSource = dt;
            lblNameOfCustomer.Text = "";
            lblTelOfCustomer.Text = "";
            txtCustomerID.Text = "";
            txtProductID.Text = "";
            txtNumberOfProduct.Text = "1";
        }
    }
}