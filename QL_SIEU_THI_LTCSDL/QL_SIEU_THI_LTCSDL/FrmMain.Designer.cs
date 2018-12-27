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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.applicationMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnUserInfo = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnManageAdminAccount = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemImport = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnManageCustomerAccount = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExport = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemProductCategory = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnReport = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemReport = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageImportExport = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonReport = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbMangeProduct = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // applicationMenu
            // 
            this.applicationMenu.Name = "applicationMenu";
            this.applicationMenu.Ribbon = this.ribbonControl;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ApplicationButtonDropDownControl = this.applicationMenu;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.barButtonItem1,
            this.barbtnLogin,
            this.barbtnLogout,
            this.barbtnUserInfo,
            this.barbtnManageAdminAccount,
            this.barButtonItemImport,
            this.barbtnManageCustomerAccount,
            this.barButtonItemExport,
            this.barButtonItemProductCategory,
            this.barButtonItemProduct,
            this.btnReport,
            this.barButtonItemReport,
            this.barButtonItem5,
            this.barButtonItem6});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonControl.MaxItemId = 21;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageImportExport});
            this.ribbonControl.Size = new System.Drawing.Size(861, 146);
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đăng nhập";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barbtnLogin
            // 
            this.barbtnLogin.Caption = "Đăng nhập";
            this.barbtnLogin.Id = 6;
            this.barbtnLogin.Name = "barbtnLogin";
            // 
            // barbtnLogout
            // 
            this.barbtnLogout.Caption = "Đăng xuất";
            this.barbtnLogout.Id = 7;
            this.barbtnLogout.Name = "barbtnLogout";
            this.barbtnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnLogout_ItemClick);
            // 
            // barbtnUserInfo
            // 
            this.barbtnUserInfo.Caption = "Thông tin tài khoản";
            this.barbtnUserInfo.Id = 8;
            this.barbtnUserInfo.Name = "barbtnUserInfo";
            // 
            // barbtnManageAdminAccount
            // 
            this.barbtnManageAdminAccount.Caption = "Tài khoản Admin";
            this.barbtnManageAdminAccount.Id = 9;
            this.barbtnManageAdminAccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnManageAdminAccount.ImageOptions.Image")));
            this.barbtnManageAdminAccount.ImageOptions.LargeImage = global::QL_SIEU_THI_LTCSDL.Properties.Resources.Seo_Admin_01_128;
            this.barbtnManageAdminAccount.Name = "barbtnManageAdminAccount";
            this.barbtnManageAdminAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnManageAdminAccount_ItemClick);
            // 
            // barButtonItemImport
            // 
            this.barButtonItemImport.Caption = "Sản phẩm";
            this.barButtonItemImport.Id = 10;
            this.barButtonItemImport.ImageOptions.Image = global::QL_SIEU_THI_LTCSDL.Properties.Resources.truck;
            this.barButtonItemImport.ImageOptions.LargeImage = global::QL_SIEU_THI_LTCSDL.Properties.Resources.truck;
            this.barButtonItemImport.Name = "barButtonItemImport";
            this.barButtonItemImport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemImport_ItemClick);
            // 
            // barbtnManageCustomerAccount
            // 
            this.barbtnManageCustomerAccount.Caption = "Tài khoản khách hàng";
            this.barbtnManageCustomerAccount.Id = 10;
            this.barbtnManageCustomerAccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnManageCustomerAccount.ImageOptions.Image")));
            this.barbtnManageCustomerAccount.ImageOptions.LargeImage = global::QL_SIEU_THI_LTCSDL.Properties.Resources.client_512;
            this.barbtnManageCustomerAccount.Name = "barbtnManageCustomerAccount";
            this.barbtnManageCustomerAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnManageCustomerAccount_ItemClick);
            // 
            // barButtonItemExport
            // 
            this.barButtonItemExport.Caption = "Bán hàng";
            this.barButtonItemExport.Id = 11;
            this.barButtonItemExport.ImageOptions.LargeImage = global::QL_SIEU_THI_LTCSDL.Properties.Resources.forklift;
            this.barButtonItemExport.Name = "barButtonItemExport";
            this.barButtonItemExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemExport_ItemClick);
            // 
            // barButtonItemProductCategory
            // 
            this.barButtonItemProductCategory.Caption = "Loại sản phẩm";
            this.barButtonItemProductCategory.Id = 12;
            this.barButtonItemProductCategory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemProductCategory.ImageOptions.Image")));
            this.barButtonItemProductCategory.ImageOptions.LargeImage = global::QL_SIEU_THI_LTCSDL.Properties.Resources._020_287_open_product_box_install_128;
            this.barButtonItemProductCategory.Name = "barButtonItemProductCategory";
            this.barButtonItemProductCategory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemProductCategory_ItemClick_1);
            // 
            // barButtonItemProduct
            // 
            this.barButtonItemProduct.Id = 16;
            this.barButtonItemProduct.Name = "barButtonItemProduct";
            // 
            // btnReport
            // 
            this.btnReport.Id = 18;
            this.btnReport.Name = "btnReport";
            // 
            // barButtonItemReport
            // 
            this.barButtonItemReport.Caption = "Doanh thu";
            this.barButtonItemReport.Id = 17;
            this.barButtonItemReport.ImageOptions.LargeImage = global::QL_SIEU_THI_LTCSDL.Properties.Resources.revenue2;
            this.barButtonItemReport.Name = "barButtonItemReport";
            this.barButtonItemReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Thông tin tài khoản";
            this.barButtonItem5.Id = 19;
            this.barButtonItem5.ImageOptions.LargeImage = global::QL_SIEU_THI_LTCSDL.Properties.Resources.account;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Đăng xuất";
            this.barButtonItem6.Id = 20;
            this.barButtonItem6.ImageOptions.LargeImage = global::QL_SIEU_THI_LTCSDL.Properties.Resources.logout;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // ribbonPageImportExport
            // 
            this.ribbonPageImportExport.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup5});
            this.ribbonPageImportExport.Name = "ribbonPageImportExport";
            this.ribbonPageImportExport.Text = "Chức năng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemProductCategory);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemImport);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemExport);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hàng hóa và bán hàng";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtnManageAdminAccount);
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtnManageCustomerAccount);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Người dùng";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItemReport);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Báo cáo & thống kê";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Thông tin và đăng xuất";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Id = -1;
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
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Báo cáo bán hàng";
            // 
            // ribbonReport
            // 
            this.ribbonReport.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonReport.Name = "ribbonReport";
            this.ribbonReport.Text = "Báo cáo";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // rbMangeProduct
            // 
            this.rbMangeProduct.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.rbMangeProduct.Name = "rbMangeProduct";
            this.rbMangeProduct.Text = "Quản lý sản phẩm";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 440);
            this.Controls.Add(this.ribbonControl);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl;
            this.Text = "Quản lý Siêu thị Mini";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barbtnLogin;
        private DevExpress.XtraBars.BarButtonItem barbtnLogout;
        private DevExpress.XtraBars.BarButtonItem barbtnUserInfo;
        private DevExpress.XtraBars.BarButtonItem barbtnManageAdminAccount;
        private DevExpress.XtraBars.BarButtonItem barButtonItemImport;
        private DevExpress.XtraBars.BarButtonItem barbtnManageCustomerAccount;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExport;
        private DevExpress.XtraBars.BarButtonItem barButtonItemProductCategory;
        private DevExpress.XtraBars.BarButtonItem barButtonItemProduct;
        private DevExpress.XtraBars.BarButtonItem btnReport;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageImportExport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbMangeProduct;
        private DevExpress.XtraBars.BarButtonItem barButtonItemReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}

