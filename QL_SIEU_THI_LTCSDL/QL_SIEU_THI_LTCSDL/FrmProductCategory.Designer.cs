namespace QL_SIEU_THI_LTCSDL
{
    partial class FrmProductCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductCategory));
            this.dgvProductCategory = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductCategory
            // 
            this.dgvProductCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode3.RelationName = "Level1";
            gridLevelNode4.RelationName = "Level2";
            this.dgvProductCategory.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3,
            gridLevelNode4});
            this.dgvProductCategory.Location = new System.Drawing.Point(3, 17);
            this.dgvProductCategory.MainView = this.gridView1;
            this.dgvProductCategory.Name = "dgvProductCategory";
            this.dgvProductCategory.Size = new System.Drawing.Size(427, 349);
            this.dgvProductCategory.TabIndex = 0;
            this.dgvProductCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Ten});
            this.gridView1.GridControl = this.dgvProductCategory;
            this.gridView1.Name = "gridView1";
            // 
            // Id
            // 
            this.Id.Caption = "Mã số";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            this.Id.Width = 60;
            // 
            // Ten
            // 
            this.Ten.Caption = "Loại sản phẩm";
            this.Ten.FieldName = "Ten";
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 1;
            this.Ten.Width = 178;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProductCategory);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 369);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách loại sản phẩm";
            // 
            // btnInsert
            // 
            this.btnInsert.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.ImageOptions.Image")));
            this.btnInsert.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnInsert.Location = new System.Drawing.Point(8, 24);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(108, 62);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Thêm vào CSDL";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(437, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(365, 262);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin loại sản phẩm";
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
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loại sản phẩm:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.simpleButton2);
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.btnCreate);
            this.groupControl2.Controls.Add(this.btnInsert);
            this.groupControl2.Location = new System.Drawing.Point(437, 268);
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
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(202, 24);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(74, 62);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Xóa";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
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
            // FrmProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 406);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProductCategory";
            this.Text = "Quản lý loại sản phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FrmProductCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvProductCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
    }
}