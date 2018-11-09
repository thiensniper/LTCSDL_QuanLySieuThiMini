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

        #region Interface Properties
        private bool normal;
        private bool NormalInterface
        {
            get { return this.normal; }
            set
            {
                this.normal = value;
                dgvCustomerAccount.Enabled = value;
                btnCreate.Enabled = value;
                btnDelete.Enabled = value;
                btnEdit.Enabled = value;
                btnSave.Enabled = !value;
                btnCancel.Enabled = !value;
                txtName.Enabled = !value;
                txtEmail.Enabled = !value;
                txtAddress.Enabled = !value;
                txtPhone.Enabled = !value;
            }
        }
        #endregion

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
            // Interface
            NormalInterface = true;
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

            // Interface
            NormalInterface = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có muốn xóa tài khoản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                listCustomerAccount.RemoveAt(listCustomerAccount.Position);
                db.SubmitChanges();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                listCustomerAccount.EndCurrentEdit();
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
            listCustomerAccount.CancelCurrentEdit();
            NormalInterface = true;
            NormalInterface = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Interface
            NormalInterface = false;
        }
    }
}