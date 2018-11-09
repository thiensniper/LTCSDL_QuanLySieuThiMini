using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SIEU_THI_LTCSDL
{
    public partial class FrmLogin : Form
    {
        DatabaseDataContext db;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tbl_Admin account = db.tbl_Admins.FirstOrDefault(res => res.UsernameOfAdmin.Equals(tbUsername.Text) && res.PasswordOfAdmin.Equals(tbPassword.Text));
            if (account != null)
            {
                SessionInfo.username = account.TenDangNhap;
                SessionInfo.authorization = account.Quyen;
                FrmMain frm = new FrmMain();
                this.Hide();
                frm.ShowDialog();
                this.Show();
                tbPassword.Clear();
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Sai thông tin đăng nhập!", "Lỗi");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();
        }
    }
}
