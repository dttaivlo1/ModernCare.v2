namespace ModernCare
{
    partial class THUOC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(THUOC));
            this.nHANVIENTableAdapter = new ModernCare._ModernCare_DBDataSetTableAdapters.NHANVIENTableAdapter();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ModernCare_DBDataSet = new ModernCare._ModernCare_DBDataSet();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.dgvChitiet = new System.Windows.Forms.DataGridView();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnADD = new DevExpress.XtraEditors.SimpleButton();
            this.txtIDPhieu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbbBenh = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.modernCareDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ModernCare_DBDataSet1 = new ModernCare._ModernCare_DBDataSet1();
            this.tHUOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHUOCTableAdapter = new ModernCare._ModernCare_DBDataSet1TableAdapters.THUOCTableAdapter();
            this.iDThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cachDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ModernCare_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modernCareDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ModernCare_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this._ModernCare_DBDataSet;
            // 
            // _ModernCare_DBDataSet
            // 
            this._ModernCare_DBDataSet.DataSetName = "_ModernCare_DBDataSet";
            this._ModernCare_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(462, 120);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(97, 46);
            this.simpleButton1.TabIndex = 83;
            this.simpleButton1.Text = "Cập nhật";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(28, 637);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(138, 24);
            this.labelControl8.TabIndex = 80;
            this.labelControl8.Text = "Tổng loại thuốc";
            // 
            // dgvChitiet
            // 
            this.dgvChitiet.AutoGenerateColumns = false;
            this.dgvChitiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChitiet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvChitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChitiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDThuocDataGridViewTextBoxColumn,
            this.tenThuocDataGridViewTextBoxColumn,
            this.cachDungDataGridViewTextBoxColumn,
            this.dVTDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn});
            this.dgvChitiet.DataSource = this.tHUOCBindingSource;
            this.dgvChitiet.Location = new System.Drawing.Point(26, 192);
            this.dgvChitiet.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChitiet.Name = "dgvChitiet";
            this.dgvChitiet.RowHeadersWidth = 51;
            this.dgvChitiet.Size = new System.Drawing.Size(777, 425);
            this.dgvChitiet.TabIndex = 79;
            // 
            // btnDel
            // 
            this.btnDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.Image")));
            this.btnDel.Location = new System.Drawing.Point(588, 120);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(97, 46);
            this.btnDel.TabIndex = 78;
            this.btnDel.Text = "Xoá";
            // 
            // btnADD
            // 
            this.btnADD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnADD.ImageOptions.Image")));
            this.btnADD.Location = new System.Drawing.Point(707, 120);
            this.btnADD.Margin = new System.Windows.Forms.Padding(4);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(97, 46);
            this.btnADD.TabIndex = 77;
            this.btnADD.Text = "Thêm";
            // 
            // txtIDPhieu
            // 
            this.txtIDPhieu.Location = new System.Drawing.Point(192, 70);
            this.txtIDPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDPhieu.Name = "txtIDPhieu";
            this.txtIDPhieu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPhieu.Properties.Appearance.Options.UseFont = true;
            this.txtIDPhieu.Properties.ReadOnly = true;
            this.txtIDPhieu.Size = new System.Drawing.Size(125, 30);
            this.txtIDPhieu.TabIndex = 74;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(28, 74);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 24);
            this.labelControl4.TabIndex = 73;
            this.labelControl4.Text = "Đơn giá";
            // 
            // cbbBenh
            // 
            this.cbbBenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBenh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBenh.FormattingEnabled = true;
            this.cbbBenh.Location = new System.Drawing.Point(568, 64);
            this.cbbBenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbBenh.Name = "cbbBenh";
            this.cbbBenh.Size = new System.Drawing.Size(235, 32);
            this.cbbBenh.TabIndex = 72;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(435, 23);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Properties.Appearance.Options.UseFont = true;
            this.txtHoTen.Properties.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(369, 30);
            this.txtHoTen.TabIndex = 71;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(335, 27);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 24);
            this.labelControl2.TabIndex = 70;
            this.labelControl2.Text = "Tên Thuốc";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(423, 67);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 24);
            this.labelControl3.TabIndex = 69;
            this.labelControl3.Text = "DVT";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(192, 26);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(125, 30);
            this.txtID.TabIndex = 68;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(28, 29);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 24);
            this.labelControl1.TabIndex = 67;
            this.labelControl1.Text = "Mã Thuốc";
            // 
            // modernCareDBDataSetBindingSource
            // 
            this.modernCareDBDataSetBindingSource.DataSource = this._ModernCare_DBDataSet;
            this.modernCareDBDataSetBindingSource.Position = 0;
            // 
            // _ModernCare_DBDataSet1
            // 
            this._ModernCare_DBDataSet1.DataSetName = "_ModernCare_DBDataSet1";
            this._ModernCare_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHUOCBindingSource
            // 
            this.tHUOCBindingSource.DataMember = "THUOC";
            this.tHUOCBindingSource.DataSource = this._ModernCare_DBDataSet1;
            // 
            // tHUOCTableAdapter
            // 
            this.tHUOCTableAdapter.ClearBeforeFill = true;
            // 
            // iDThuocDataGridViewTextBoxColumn
            // 
            this.iDThuocDataGridViewTextBoxColumn.DataPropertyName = "ID_Thuoc";
            this.iDThuocDataGridViewTextBoxColumn.HeaderText = "ID_Thuoc";
            this.iDThuocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDThuocDataGridViewTextBoxColumn.Name = "iDThuocDataGridViewTextBoxColumn";
            // 
            // tenThuocDataGridViewTextBoxColumn
            // 
            this.tenThuocDataGridViewTextBoxColumn.DataPropertyName = "TenThuoc";
            this.tenThuocDataGridViewTextBoxColumn.HeaderText = "TenThuoc";
            this.tenThuocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenThuocDataGridViewTextBoxColumn.Name = "tenThuocDataGridViewTextBoxColumn";
            // 
            // cachDungDataGridViewTextBoxColumn
            // 
            this.cachDungDataGridViewTextBoxColumn.DataPropertyName = "CachDung";
            this.cachDungDataGridViewTextBoxColumn.HeaderText = "CachDung";
            this.cachDungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cachDungDataGridViewTextBoxColumn.Name = "cachDungDataGridViewTextBoxColumn";
            // 
            // dVTDataGridViewTextBoxColumn
            // 
            this.dVTDataGridViewTextBoxColumn.DataPropertyName = "DVT";
            this.dVTDataGridViewTextBoxColumn.HeaderText = "DVT";
            this.dVTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dVTDataGridViewTextBoxColumn.Name = "dVTDataGridViewTextBoxColumn";
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            // 
            // THUOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 679);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.dgvChitiet);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.txtIDPhieu);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbbBenh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelControl1);
            this.Name = "THUOC";
            this.Text = "THUOC";
            this.Load += new System.EventHandler(this.THUOC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ModernCare_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modernCareDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ModernCare_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUOCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _ModernCare_DBDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private _ModernCare_DBDataSet _ModernCare_DBDataSet;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.DataGridView dgvChitiet;
        private System.Windows.Forms.BindingSource modernCareDBDataSetBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.SimpleButton btnADD;
        private DevExpress.XtraEditors.TextEdit txtIDPhieu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cbbBenh;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private _ModernCare_DBDataSet1 _ModernCare_DBDataSet1;
        private System.Windows.Forms.BindingSource tHUOCBindingSource;
        private _ModernCare_DBDataSet1TableAdapters.THUOCTableAdapter tHUOCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cachDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
    }
}