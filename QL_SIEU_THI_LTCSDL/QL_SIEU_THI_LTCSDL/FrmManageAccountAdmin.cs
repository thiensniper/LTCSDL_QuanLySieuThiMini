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
    public partial class FrmManageAccountAdmin : DevExpress.XtraEditors.XtraForm
    {
        Table<tbl_TaiKhoan> tbl_AdminAccount;
        DataAdminAccountDataContext db;
        BindingManagerBase listAdminAccount;

        public FrmManageAccountAdmin()
        {
            InitializeComponent();
        }

        private void FrmManageAccountAdmin_Load(object sender, EventArgs e)
        {
            db = new DataAdminAccountDataContext();
            tbl_AdminAccount = db.tbl_TaiKhoans;

            LoadDataToCBOAuthorization();
            LoadDatabaseToDataGridView();

            //Binding
            txtName.DataBindings.Add("Text", tbl_AdminAccount, "HoTen", true);
            txtUsername.DataBindings.Add("Text", tbl_AdminAccount, "TenDangNhap", true);
            txtPassword.DataBindings.Add("Text", tbl_AdminAccount, "MatKhau", true);
            txtPhone.DataBindings.Add("Text", tbl_AdminAccount, "Sdt", true);
            cboAuthorization.DataBindings.Add("Text", tbl_AdminAccount, "Quyen", true);
            listAdminAccount = this.BindingContext[tbl_AdminAccount];
        }

        private void LoadDataToCBOAuthorization()
        {
            cboAuthorization.Properties.Items.Add("Manager");
            cboAuthorization.Properties.Items.Add("Import");
            cboAuthorization.Properties.Items.Add("Export");

            cboAuthorization.SelectedIndex = 0;
        }

        private void LoadDatabaseToDataGridView()
        {
            dgvAdminAccount.DataSource = tbl_AdminAccount;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                listAdminAccount.EndCurrentEdit();
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            listAdminAccount.AddNew();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listAdminAccount.RemoveAt(listAdminAccount.Position);
            db.SubmitChanges();
        }
    }
}