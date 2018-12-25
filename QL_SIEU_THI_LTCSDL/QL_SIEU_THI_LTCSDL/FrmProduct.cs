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
        private Table<tbl_Product> tbl_Product;
        private Table<tbl_ProductCategory> tbl_ProductCategory;
        
        private DatabaseDataContext db;
        private BindingManagerBase ListProduct;

        #region Interface Properties
        private bool normal;
        private bool NormalInterface
        {
            get { return this.normal; }
            set
            {
                this.normal = value;
                dgvProduct.Enabled = value;
                btnCreate.Enabled = value;
                btnDelete.Enabled = value;
                btnEdit.Enabled = value;
                btnSave.Enabled = !value;
                btnCancel.Enabled = !value;
                txtName.Enabled = !value;
                nupAmount.Enabled = !value;
                txtPrice.Enabled = !value;
                cboProductCategory.Enabled = !value;
            }
        }
        #endregion


        public FrmProduct()
        {
            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();
            tbl_Product = db.tbl_Products;
            tbl_ProductCategory = db.tbl_ProductCategories;

            /*if (db.tbl_LoaiHangHoas.ToList().Count==0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Không có loại sản phẩm trong CSDL", "Thông báo");
                this.Close();
            }*/

            LoadDatabaseToCombobox();
            LoadDatabaseToDataGridView();

            // Interface
            NormalInterface = true;
            //Binding
            txtName.DataBindings.Add("Text", tbl_Product, "NameOfProduct", true);
            nupAmount.DataBindings.Add("Text", tbl_Product, "NumberOfProduct", true);
            txtPrice.DataBindings.Add("Text", tbl_Product, "PriceOfProduct", true);
            cboProductCategory.DataBindings.Add("SelectedValue", tbl_Product, "ProductCategoryID", true);

            ListProduct = this.BindingContext[tbl_Product];
        }

        private void LoadDatabaseToCombobox()
        {
            cboProductCategory.DataSource = tbl_ProductCategory;
            cboProductCategory.DisplayMember = "NameOfProductCategory";
            cboProductCategory.ValueMember = "ProductCategoryID";
        }

        private void LoadDatabaseToDataGridView()
        {
            dgvProduct.DataSource = tbl_Product;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ListProduct.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0 || txtPrice.Text.Length == 0 || cboProductCategory.SelectedIndex == -1)
            {
                XtraMessageBox.Show("Thông tin không được trống!", "Thông báo");
                return;
            }
            try
            {
                ListProduct.EndCurrentEdit();
                db.SubmitChanges();
                XtraMessageBox.Show("Lưu vào CSDL thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            // Interface
            NormalInterface = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Interface
            NormalInterface = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ChangeSet changeSet = db.GetChangeSet();
            db.Refresh(RefreshMode.OverwriteCurrentValues, changeSet.Updates);
            ListProduct.CancelCurrentEdit();
            NormalInterface = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ListProduct.RemoveAt(ListProduct.Position);
                db.SubmitChanges();
            }
        }
    }
}