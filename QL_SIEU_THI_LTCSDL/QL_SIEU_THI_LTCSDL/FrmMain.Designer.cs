namespace QL_SIEU_THI_LTCSDL
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu();
            this.barbtnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnUserInfo = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnManageAdminAccount = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemImport = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnManageCustomerAccount = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageImportExport = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItemExport = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageManageAccount = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ApplicationButtonDropDownControl = this.applicationMenu;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.barButtonItem1,
            this.barbtnLogin,
            this.barbtnLogout,
            this.barbtnUserInfo,
            this.barbtnManageAdminAccount,
            this.barButtonItemImport,
            this.barbtnManageCustomerAccount});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonControl.MaxItemId = 11;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageImportExport,
            this.ribbonPageManageAccount});
            this.ribbonControl.Size = new System.Drawing.Size(700, 187);
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // applicationMenu
            // 
            this.applicationMenu.ItemLinks.Add(this.barbtnLogin);
            this.applicationMenu.ItemLinks.Add(this.barbtnUserInfo);
            this.applicationMenu.ItemLinks.Add(this.barbtnLogout);
            this.applicationMenu.Name = "applicationMenu";
            this.applicationMenu.Ribbon = this.ribbonControl;
            // 
            // barbtnLogin
            // 
            this.barbtnLogin.Caption = "Đăng nhập";
            this.barbtnLogin.Id = 6;
            this.barbtnLogin.Name = "barbtnLogin";
            this.barbtnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnLogin_ItemClick);
            // 
            // barbtnUserInfo
            // 
            this.barbtnUserInfo.Caption = "Thông tin tài khoản";
            this.barbtnUserInfo.Id = 8;
            this.barbtnUserInfo.Name = "barbtnUserInfo";
            // 
            // barbtnLogout
            // 
            this.barbtnLogout.Caption = "Đăng xuất";
            this.barbtnLogout.Id = 7;
            this.barbtnLogout.Name = "barbtnLogout";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đăng nhập";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barbtnManageAdminAccount
            // 
            this.barbtnManageAdminAccount.Caption = "Quản lý tài khoản Admin";
            this.barbtnManageAdminAccount.Id = 9;
            this.barbtnManageAdminAccount.Name = "barbtnManageAdminAccount";
            this.barbtnManageAdminAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnManageAdminAccount_ItemClick);
            // 
            // barButtonItemImport
            // 
            this.barButtonItemImport.Caption = "Nhập hàng";
            this.barButtonItemImport.Id = 10;
            this.barButtonItemImport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemImport.ImageOptions.LargeImage")));
            this.barButtonItemImport.Name = "barButtonItemImport";
            // 
            // barbtnManageCustomerAccount
            // 
            this.barbtnManageCustomerAccount.Caption = "Quản lý tài khoản khách hàng";
            this.barbtnManageCustomerAccount.Id = 10;
            this.barbtnManageCustomerAccount.Name = "barbtnManageCustomerAccount";
            this.barbtnManageCustomerAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnManageCustomerAccount_ItemClick);
            // 
            // ribbonPageImportExport
            // 
            this.ribbonPageImportExport.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPageImportExport.Name = "ribbonPageImportExport";
            this.ribbonPageImportExport.Text = "Nhập/Xuất hàng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemImport);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemExport);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // barButtonItemExport
            // 
            this.barButtonItemExport.Caption = "Xuất hàng";
            this.barButtonItemExport.Id = 11;
            this.barButtonItemExport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemExport.ImageOptions.LargeImage")));
            this.barButtonItemExport.Name = "barButtonItemExport";
            // 
            // ribbonPageManageAccount
            // 
            this.ribbonPageManageAccount.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPageManageAccount.Name = "ribbonPageManageAccount";
            this.ribbonPageManageAccount.Text = "Quản lý tài khoản";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barbtnManageAdminAccount);
            this.ribbonPageGroup3.ItemLinks.Add(this.barbtnManageCustomerAccount);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Quản lý tài khoản Admin";
            this.barButtonItem3.Id = 9;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Quản lý tài khoản Admin";
            this.barButtonItem4.Id = 9;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.ribbonControl);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl;
            this.Text = "Quản lý Siêu thị Mini";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageImportExport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barbtnLogin;
        private DevExpress.XtraBars.BarButtonItem barbtnUserInfo;
        private DevExpress.XtraBars.BarButtonItem barbtnLogout;
        private DevExpress.XtraBars.BarButtonItem barbtnManageAdminAccount;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageManageAccount;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItemImport;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExport;
        private DevExpress.XtraBars.BarButtonItem barbtnManageCustomerAccount;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

