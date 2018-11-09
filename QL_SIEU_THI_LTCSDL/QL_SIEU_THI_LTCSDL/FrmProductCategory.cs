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
        public FrmProductCategory()
        {
            InitializeComponent();
        }

        private void FrmProductCategory_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();
            tbl_ProductCategory= db.tbl_ProductCategories;

            LoadDatabaseToDataGridView();

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
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listProductCategory.RemoveAt(listProductCategory.Position);
            db.SubmitChanges();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                listProductCategory.EndCurrentEdit();
                db.SubmitChanges();
                DevExpress.XtraEditors.XtraMessageBox.Show("Lưu vào CSDL thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                listProductCategory.EndCurrentEdit();
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