﻿namespace QL_SIEU_THI_LTCSDL
{
    partial class FrmProduct
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProduct = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NameOfProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumberOfProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NameOfProductCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PriceOfProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cboProductCategory = new System.Windows.Forms.ComboBox();
            this.nupAmount = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.colId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colId = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colTen = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colTen = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colSoLuong = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colIdLoaiHang = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colIdLoaiHang = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colGiaBan = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colGiaBan = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.coltbl_LoaiHangHoa = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_coltbl_LoaiHangHoa = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colIdLoaiHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_coltbl_LoaiHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProduct);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(780, 454);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // dgvProduct
            // 
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridLevelNode3.RelationName = "Level1";
            gridLevelNode4.RelationName = "Level2";
            this.dgvProduct.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3,
            gridLevelNode4});
            this.dgvProduct.Location = new System.Drawing.Point(3, 20);
            this.dgvProduct.MainView = this.gridView1;
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(774, 430);
            this.dgvProduct.TabIndex = 1;
            this.dgvProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProductID,
            this.NameOfProduct,
            this.NumberOfProduct,
            this.NameOfProductCategory,
            this.PriceOfProduct});
            this.gridView1.GridControl = this.dgvProduct;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // ProductID
            // 
            this.ProductID.Caption = "Mã số";
            this.ProductID.FieldName = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.Visible = true;
            this.ProductID.VisibleIndex = 0;
            this.ProductID.Width = 60;
            // 
            // NameOfProduct
            // 
            this.NameOfProduct.Caption = "Tên sản phẩm";
            this.NameOfProduct.FieldName = "NameOfProduct";
            this.NameOfProduct.Name = "NameOfProduct";
            this.NameOfProduct.Visible = true;
            this.NameOfProduct.VisibleIndex = 1;
            this.NameOfProduct.Width = 178;
            // 
            // NumberOfProduct
            // 
            this.NumberOfProduct.Caption = "Số lượng";
            this.NumberOfProduct.FieldName = "NumberOfProduct";
            this.NumberOfProduct.Name = "NumberOfProduct";
            this.NumberOfProduct.Visible = true;
            this.NumberOfProduct.VisibleIndex = 2;
            this.NumberOfProduct.Width = 100;
            // 
            // NameOfProductCategory
            // 
            this.NameOfProductCategory.Caption = "Loại sản phẩm";
            this.NameOfProductCategory.FieldName = "ProductCategoryID";
            this.NameOfProductCategory.Name = "NameOfProductCategory";
            this.NameOfProductCategory.Visible = true;
            this.NameOfProductCategory.VisibleIndex = 3;
            this.NameOfProductCategory.Width = 100;
            // 
            // PriceOfProduct
            // 
            this.PriceOfProduct.Caption = "Đơn giá";
            this.PriceOfProduct.FieldName = "PriceOfProduct";
            this.PriceOfProduct.Name = "PriceOfProduct";
            this.PriceOfProduct.Visible = true;
            this.PriceOfProduct.VisibleIndex = 4;
            this.PriceOfProduct.Width = 113;
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl1.Controls.Add(this.cboProductCategory);
            this.groupControl1.Controls.Add(this.nupAmount);
            this.groupControl1.Controls.Add(this.txtPrice);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Location = new System.Drawing.Point(787, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(470, 322);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin sản phẩm";
            // 
            // cboProductCategory
            // 
            this.cboProductCategory.FormattingEnabled = true;
            this.cboProductCategory.Location = new System.Drawing.Point(140, 140);
            this.cboProductCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboProductCategory.Name = "cboProductCategory";
            this.cboProductCategory.Size = new System.Drawing.Size(275, 24);
            this.cboProductCategory.TabIndex = 17;
            // 
            // nupAmount
            // 
            this.nupAmount.Location = new System.Drawing.Point(140, 75);
            this.nupAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nupAmount.Name = "nupAmount";
            this.nupAmount.Size = new System.Drawing.Size(275, 23);
            this.nupAmount.TabIndex = 16;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(140, 108);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(275, 22);
            this.txtPrice.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 44);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(275, 22);
            this.txtName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Loại sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giá bán:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnCancel);
            this.groupControl2.Controls.Add(this.btnSave);
            this.groupControl2.Controls.Add(this.btnEdit);
            this.groupControl2.Controls.Add(this.btnDelete);
            this.groupControl2.Controls.Add(this.btnCreate);
            this.groupControl2.Location = new System.Drawing.Point(787, 330);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(470, 121);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Chức năng";
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.LayoutViewField = this.layoutViewField_colId;
            this.colId.Name = "colId";
            // 
            // layoutViewField_colId
            // 
            this.layoutViewField_colId.EditorPreferredWidth = 104;
            this.layoutViewField_colId.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colId.Name = "layoutViewField_colId";
            this.layoutViewField_colId.Size = new System.Drawing.Size(203, 120);
            this.layoutViewField_colId.TextSize = new System.Drawing.Size(14, 13);
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.LayoutViewField = this.layoutViewField_colTen;
            this.colTen.Name = "colTen";
            // 
            // layoutViewField_colTen
            // 
            this.layoutViewField_colTen.EditorPreferredWidth = 104;
            this.layoutViewField_colTen.Location = new System.Drawing.Point(0, 20);
            this.layoutViewField_colTen.Name = "layoutViewField_colTen";
            this.layoutViewField_colTen.Size = new System.Drawing.Size(203, 100);
            this.layoutViewField_colTen.TextSize = new System.Drawing.Size(14, 13);
            // 
            // colSoLuong
            // 
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.LayoutViewField = this.layoutViewField_colSoLuong;
            this.colSoLuong.Name = "colSoLuong";
            // 
            // layoutViewField_colSoLuong
            // 
            this.layoutViewField_colSoLuong.EditorPreferredWidth = 104;
            this.layoutViewField_colSoLuong.Location = new System.Drawing.Point(0, 40);
            this.layoutViewField_colSoLuong.Name = "layoutViewField_colSoLuong";
            this.layoutViewField_colSoLuong.Size = new System.Drawing.Size(203, 80);
            this.layoutViewField_colSoLuong.TextSize = new System.Drawing.Size(22, 13);
            // 
            // colIdLoaiHang
            // 
            this.colIdLoaiHang.FieldName = "IdLoaiHang";
            this.colIdLoaiHang.LayoutViewField = this.layoutViewField_colIdLoaiHang;
            this.colIdLoaiHang.Name = "colIdLoaiHang";
            // 
            // layoutViewField_colIdLoaiHang
            // 
            this.layoutViewField_colIdLoaiHang.EditorPreferredWidth = 104;
            this.layoutViewField_colIdLoaiHang.Location = new System.Drawing.Point(0, 60);
            this.layoutViewField_colIdLoaiHang.Name = "layoutViewField_colIdLoaiHang";
            this.layoutViewField_colIdLoaiHang.Size = new System.Drawing.Size(203, 60);
            this.layoutViewField_colIdLoaiHang.TextSize = new System.Drawing.Size(48, 13);
            // 
            // colGiaBan
            // 
            this.colGiaBan.FieldName = "GiaBan";
            this.colGiaBan.LayoutViewField = this.layoutViewField_colGiaBan;
            this.colGiaBan.Name = "colGiaBan";
            // 
            // layoutViewField_colGiaBan
            // 
            this.layoutViewField_colGiaBan.EditorPreferredWidth = 104;
            this.layoutViewField_colGiaBan.Location = new System.Drawing.Point(0, 80);
            this.layoutViewField_colGiaBan.Name = "layoutViewField_colGiaBan";
            this.layoutViewField_colGiaBan.Size = new System.Drawing.Size(203, 40);
            this.layoutViewField_colGiaBan.TextSize = new System.Drawing.Size(64, 13);
            // 
            // coltbl_LoaiHangHoa
            // 
            this.coltbl_LoaiHangHoa.FieldName = "tbl_LoaiHangHoa";
            this.coltbl_LoaiHangHoa.LayoutViewField = this.layoutViewField_coltbl_LoaiHangHoa;
            this.coltbl_LoaiHangHoa.Name = "coltbl_LoaiHangHoa";
            // 
            // layoutViewField_coltbl_LoaiHangHoa
            // 
            this.layoutViewField_coltbl_LoaiHangHoa.EditorPreferredWidth = 104;
            this.layoutViewField_coltbl_LoaiHangHoa.Location = new System.Drawing.Point(0, 100);
            this.layoutViewField_coltbl_LoaiHangHoa.Name = "layoutViewField_coltbl_LoaiHangHoa";
            this.layoutViewField_coltbl_LoaiHangHoa.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_coltbl_LoaiHangHoa.TextSize = new System.Drawing.Size(64, 13);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "IdLoaiHang";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // GiaBan
            // 
            this.GiaBan.Caption = "Giá bán";
            this.GiaBan.FieldName = "GiaBan";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Width = 100;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 100;
            // 
            // Ten
            // 
            this.Ten.Caption = "Tên sản phẩm";
            this.Ten.FieldName = "Ten";
            this.Ten.Name = "Ten";
            this.Ten.Width = 178;
            // 
            // Id
            // 
            this.Id.Caption = "Mã số";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 60;
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(374, 29);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 76);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(281, 29);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 76);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnEdit.Location = new System.Drawing.Point(190, 29);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 76);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(97, 29);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 76);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.ImageOptions.Image")));
            this.btnCreate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCreate.Location = new System.Drawing.Point(5, 29);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(86, 76);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Tạo mới";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 500);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmProduct";
            this.Text = "Quản lý sản phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colIdLoaiHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_coltbl_LoaiHangHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private System.Windows.Forms.NumericUpDown nupAmount;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colId;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colTen;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colTen;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colSoLuong;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colSoLuong;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colIdLoaiHang;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colIdLoaiHang;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colGiaBan;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colGiaBan;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn coltbl_LoaiHangHoa;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_coltbl_LoaiHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.GridControl dgvProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ProductID;
        private DevExpress.XtraGrid.Columns.GridColumn NameOfProduct;
        private DevExpress.XtraGrid.Columns.GridColumn NumberOfProduct;
        private DevExpress.XtraGrid.Columns.GridColumn NameOfProductCategory;
        private DevExpress.XtraGrid.Columns.GridColumn PriceOfProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboProductCategory;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
    }
}