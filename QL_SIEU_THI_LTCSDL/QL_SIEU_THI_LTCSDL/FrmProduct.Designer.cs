namespace QL_SIEU_THI_LTCSDL
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLoaiHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tblLoaiHangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblHangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.nupAmount = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoaiHangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHangHoaBindingSource)).BeginInit();
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
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 369);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.idLoaiHangDataGridViewTextBoxColumn,
            this.giaBanDataGridViewTextBoxColumn});
            this.dgvProduct.DataSource = this.tblHangHoaBindingSource;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(3, 17);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(663, 349);
            this.dgvProduct.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Mã số";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // idLoaiHangDataGridViewTextBoxColumn
            // 
            this.idLoaiHangDataGridViewTextBoxColumn.DataPropertyName = "IdLoaiHang";
            this.idLoaiHangDataGridViewTextBoxColumn.DataSource = this.tblLoaiHangHoaBindingSource;
            this.idLoaiHangDataGridViewTextBoxColumn.DisplayMember = "Ten";
            this.idLoaiHangDataGridViewTextBoxColumn.HeaderText = "Loại sản phẩm";
            this.idLoaiHangDataGridViewTextBoxColumn.Name = "idLoaiHangDataGridViewTextBoxColumn";
            this.idLoaiHangDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idLoaiHangDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idLoaiHangDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // tblLoaiHangHoaBindingSource
            // 
            this.tblLoaiHangHoaBindingSource.DataSource = typeof(QL_SIEU_THI_LTCSDL.tbl_LoaiHangHoa);
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            this.giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.HeaderText = "Giá bán";
            this.giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            // 
            // tblHangHoaBindingSource
            // 
            this.tblHangHoaBindingSource.DataSource = typeof(QL_SIEU_THI_LTCSDL.tbl_HangHoa);
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl1.Controls.Add(this.nupAmount);
            this.groupControl1.Controls.Add(this.txtPrice);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Location = new System.Drawing.Point(675, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(365, 262);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin sản phẩm";
            // 
            // nupAmount
            // 
            this.nupAmount.Location = new System.Drawing.Point(120, 61);
            this.nupAmount.Name = "nupAmount";
            this.nupAmount.Size = new System.Drawing.Size(236, 21);
            this.nupAmount.TabIndex = 16;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(120, 88);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(236, 20);
            this.txtPrice.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 20);
            this.txtName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giá bán:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.simpleButton2);
            this.groupControl2.Controls.Add(this.btnDelete);
            this.groupControl2.Controls.Add(this.btnCreate);
            this.groupControl2.Location = new System.Drawing.Point(675, 268);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(365, 98);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Chức năng";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton2.Location = new System.Drawing.Point(282, 24);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(74, 62);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "Cập nhật";
            this.simpleButton2.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(202, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 62);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.ImageOptions.Image")));
            this.btnCreate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCreate.Location = new System.Drawing.Point(122, 24);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(74, 62);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Tạo mới";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
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
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 406);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProduct";
            this.Text = "Quản lý sản phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoaiHangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHangHoaBindingSource)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
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
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.BindingSource tblLoaiHangHoaBindingSource;
        private System.Windows.Forms.BindingSource tblHangHoaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idLoaiHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
    }
}