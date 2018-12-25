﻿using System;
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
        Table<tbl_Admin> tbl_AdminAccount;
        DatabaseDataContext db;
        BindingManagerBase listAdminAccount;

        #region Interface Properties
        private bool normal;
        private bool NormalInterface
        {
            get { return this.normal; }
            set
            {
                this.normal = value;
                dgvAdminAccount.Enabled = value;
                btnCreate.Enabled = value;
                btnDelete.Enabled = value;
                btnEdit.Enabled = value;
                btnSave.Enabled = !value;
                btnCancel.Enabled = !value;
                txtName.Enabled = !value;
                txtUsername.Enabled = !value;
                txtPassword.Enabled = !value;
                txtPhone.Enabled = !value;
                cboAuthorization.Enabled = !value;
            }
        }
        #endregion

        public FrmManageAccountAdmin()
        {
            InitializeComponent();
        }

        private void FrmManageAccountAdmin_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();
            tbl_AdminAccount = db.tbl_Admins;

            LoadDataToCBOAuthorization();
            LoadDatabaseToDataGridView();
            // Interface
            NormalInterface = true;
            //Binding
            txtName.DataBindings.Add("Text", tbl_AdminAccount, "NameOfAdmin", true);
            txtUsername.DataBindings.Add("Text", tbl_AdminAccount, "UsernameOfAdmin", true);
            txtPassword.DataBindings.Add("Text", tbl_AdminAccount, "PasswordOfAdmin", true);
            txtPhone.DataBindings.Add("Text", tbl_AdminAccount, "TelOfAdmin", true);
            cboAuthorization.DataBindings.Add("Text", tbl_AdminAccount, "AuthorizationOfAdmin", true);
            listAdminAccount = this.BindingContext[tbl_AdminAccount];
        }

        private void LoadDataToCBOAuthorization()
        {
            cboAuthorization.Properties.Items.Add("Manager");
            cboAuthorization.Properties.Items.Add("Staff");

            cboAuthorization.SelectedIndex = 0;
        }

        private void LoadDatabaseToDataGridView()
        {
            dgvAdminAccount.DataSource = tbl_AdminAccount;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            listAdminAccount.AddNew();

            // Interface
            NormalInterface = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có muốn xóa tài khoản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                listAdminAccount.RemoveAt(listAdminAccount.Position);
                db.SubmitChanges();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ChangeSet changeSet = db.GetChangeSet();
            db.Refresh(RefreshMode.OverwriteCurrentValues, changeSet.Updates);
            listAdminAccount.CancelCurrentEdit();
            NormalInterface = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải từ 6 kí tự trở lên!", "Thông báo");
                return;
            }
            try
            {
                listAdminAccount.EndCurrentEdit();
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
    }
}