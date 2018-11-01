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
    public partial class FrmManageAccountCustomercs : DevExpress.XtraEditors.XtraForm
    {
        Table<tbl_KhachHang> tbl_CustomerAccount;
        DatabaseDataContext db;
        BindingManagerBase listCustomerAccount;

        public FrmManageAccountCustomercs()
        {
            InitializeComponent();
        }

        private void FrmManageAccountCustomercs_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();
            tbl_CustomerAccount = db.tbl_KhachHangs;

            LoadDatabaseToDataGridView();

            txtName.DataBindings.Add("Text", tbl_CustomerAccount, "HoTen", true);
            txtAddress.DataBindings.Add("Text", tbl_CustomerAccount, "DiaChi", true);
            txtEmail.DataBindings.Add("Text", tbl_CustomerAccount, "Email", true);
            txtPhone.DataBindings.Add("Text", tbl_CustomerAccount, "Sdt", true);
            listCustomerAccount = this.BindingContext[tbl_CustomerAccount];
        }

        private void LoadDatabaseToDataGridView()
        {
            dgvCustomerAccount.DataSource = tbl_CustomerAccount;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                listCustomerAccount.EndCurrentEdit();
                db.SubmitChanges();
                DevExpress.XtraEditors.XtraMessageBox.Show("Lưu vào CSDL thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            listCustomerAccount.AddNew();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listCustomerAccount.RemoveAt(listCustomerAccount.Position);
            db.SubmitChanges();
        }
    }
}