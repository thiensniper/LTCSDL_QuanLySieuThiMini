using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Linq;

namespace QL_SIEU_THI_LTCSDL
{
    //yêu cầu: Tồn tại ít nhất 1 loại sản phẩm.
    public partial class FrmProduct : DevExpress.XtraEditors.XtraForm
    {
        private Table<tbl_HangHoa> tbl_Product;
        
        private DatabaseDataContext db;

        public FrmProduct()
        {
            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();

            if (db.tbl_LoaiHangHoas.ToList().Count==0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Không có loại sản phẩm trong CSDL", "Thông báo");
                this.Close();
            }

            LoadDatabaseToDataGridView();

            tblLoaiHangHoaBindingSource.DataSource = db.tbl_LoaiHangHoas;

            //Binding
            txtName.DataBindings.Add("Text", tblHangHoaBindingSource, "Ten");
            nupAmount.DataBindings.Add("Text", tblHangHoaBindingSource, "SoLuong");
            txtPrice.DataBindings.Add("Text", tblHangHoaBindingSource, "GiaBan");
        }

        private void LoadDatabaseToDataGridView()
        {
            tbl_Product = db.tbl_HangHoas;
            tblHangHoaBindingSource.DataSource = tbl_Product;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Lấy đại 1 loại hàng hóa
            try
            {
                int id = db.tbl_LoaiHangHoas.ToList()[0].Id;
                tblHangHoaBindingSource.Add(new tbl_HangHoa(){ IdLoaiHang = id });
            }
            catch(Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Không có loại sản phẩm trong CSDL", "Thông báo");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                tblHangHoaBindingSource.EndEdit();
                db.SubmitChanges();
                DevExpress.XtraEditors.XtraMessageBox.Show("Lưu vào CSDL thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}