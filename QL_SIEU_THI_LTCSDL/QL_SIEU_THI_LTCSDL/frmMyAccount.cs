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

namespace QL_SIEU_THI_LTCSDL
{
    public partial class frmMyAccount : DevExpress.XtraEditors.XtraForm
    {
        private DatabaseDataContext db;

        public frmMyAccount()
        {
            InitializeComponent();
        }

        private void frmMyAccount_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();
            loadInformationOfMyAccount();
        }

        private void loadInformationOfMyAccount()
        {
            tbl_Admin admin = db.tbl_Admins.FirstOrDefault(res => res.AdminID == SessionInfo.adminID);
            txtName.Text = admin.NameOfAdmin;
            txtPassword.Text = "";
            txtPhone.Text = admin.TelOfAdmin;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_Admin admin = db.tbl_Admins.SingleOrDefault(res => res.AdminID == SessionInfo.adminID);
                admin.NameOfAdmin = txtName.Text;
                admin.PasswordOfAdmin = (txtPassword.Text.Length == 0 ? admin.PasswordOfAdmin : txtPassword.Text);
                admin.TelOfAdmin = txtPhone.Text;
                db.SubmitChanges();
                XtraMessageBox.Show("Lưu vào CSDL thành công", "Thông báo");
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi lưu vào CSDL", "Thông báo");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}