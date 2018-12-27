﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SIEU_THI_LTCSDL
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public void OpenForm(Type typeform)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeform)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeform);
            f.MdiParent = this;
            f.Show();
        }

        private void barbtnManageAdminAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.OpenForm(typeof(FrmManageAccountAdmin));
        }

        private void barbtnManageCustomerAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.OpenForm(typeof(FrmManageAccountCustomercs));
        }

        private void barbtnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItemExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.OpenForm(typeof(FrmPayment));
        }

        private void barButtonItemProductCategory_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.OpenForm(typeof(FrmProductCategory));
        }
        
        private void barButtonItemImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.OpenForm(typeof(FrmProduct));
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.OpenForm(typeof(FrmReport));
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.OpenForm(typeof(frmMyAccount));
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CheckIfIsAStaff();
        }

        private void CheckIfIsAStaff()
        {
            if (SessionInfo.authorization.Equals("Staff"))
            {
                barButtonItemProductCategory.Enabled = false;
                barbtnManageAdminAccount.Enabled = false;
                barButtonItemReport.Enabled = false;
            }
        }
    }
}
