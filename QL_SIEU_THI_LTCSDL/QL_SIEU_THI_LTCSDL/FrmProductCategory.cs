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
    public partial class FrmProductCategory : DevExpress.XtraEditors.XtraForm
    {
        Table<tbl_ProductCategory> tbl_ProductCategory;
        DatabaseDataContext db;
        BindingManagerBase listProductCategory;

        #region Interface Properties
        private bool normal;
        private bool NormalInterface
        {
            get { return this.normal; }
            set
            {
                this.normal = value;
                dgvProductCategory.Enabled = value;
                btnCreate.Enabled = value;
                btnDelete.Enabled = value;
                btnEdit.Enabled = value;
                btnSave.Enabled = !value;
                btnCancel.Enabled = !value;
                txtName.Enabled = !value;
            }
        }
        #endregion

        public FrmProductCategory()
        {
            InitializeComponent();
        }

        private void FrmProductCategory_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();
            tbl_ProductCategory= db.tbl_ProductCategories;

            LoadDatabaseToDataGridView();

            // Interface
            NormalInterface = true;
            //Binding
            txtName.DataBindings.Add("Text", tbl_ProductCategory, "NameOfProductCategory");
            listProductCategory = this.BindingContext[tbl_ProductCategory];
        }

        private void LoadDatabaseToDataGridView()
        {
            dgvProductCategory.DataSource = tbl_ProductCategory;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            listProductCategory.AddNew();

            // Interface
            NormalInterface = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                listProductCategory.RemoveAt(listProductCategory.Position);
                db.SubmitChanges();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("Tên không được trống!", "Thông báo");
                return;
            }
            try
            {
                listProductCategory.EndCurrentEdit();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ChangeSet changeSet = db.GetChangeSet();
            db.Refresh(RefreshMode.OverwriteCurrentValues, changeSet.Updates);
            listProductCategory.CancelCurrentEdit();
            NormalInterface = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Interface
            NormalInterface = false;
        }
    }
}