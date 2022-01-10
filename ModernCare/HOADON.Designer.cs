namespace ModernCare
{
    partial class HOADON
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
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.dgvChitiet = new System.Windows.Forms.DataGridView();
            this.tHUOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ModernCare_DBDataSet1 = new ModernCare._ModernCare_DBDataSet1();
            this.tHUOCTableAdapter = new ModernCare._ModernCare_DBDataSet1TableAdapters.THUOCTableAdapter();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this._ModernCare_DBDataSet = new ModernCare._ModernCare_DBDataSet();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modernCareDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new ModernCare._ModernCare_DBDataSetTableAdapters.NHANVIENTableAdapter();
            this._ModernCare_DBDataSet3 = new ModernCare._ModernCare_DBDataSet3();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOADONTableAdapter = new ModernCare._ModernCare_DBDataSet3TableAdapters.HOADONTableAdapter();
            this.iDHoaDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDThuNganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPhieuKhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ModernCare_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ModernCare_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modernCareDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ModernCare_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(13, 550);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(209, 24);
            this.labelControl8.TabIndex = 95;
            this.labelControl8.Text = "Tổng hoá đơn đã xuất: ";
            // 
            // dgvChitiet
            // 
            this.dgvChitiet.AutoGenerateColumns = false;
            this.dgvChitiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChitiet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvChitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChitiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDHoaDonDataGridViewTextBoxColumn,
            this.iDThuNganDataGridViewTextBoxColumn,
            this.iDPhieuKhamDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn,
            this.ngayXuatDataGridViewTextBoxColumn});
            this.dgvChitiet.DataSource = this.hOADONBindingSource;
            this.dgvChitiet.Location = new System.Drawing.Point(13, 105);
            this.dgvChitiet.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChitiet.Name = "dgvChitiet";
            this.dgvChitiet.RowHeadersWidth = 51;
            this.dgvChitiet.Size = new System.Drawing.Size(777, 425);
            this.dgvChitiet.TabIndex = 94;
            // 
            // tHUOCBindingSource
            // 
            this.tHUOCBindingSource.DataMember = "THUOC";
            this.tHUOCBindingSource.DataSource = this._ModernCare_DBDataSet1;
            // 
            // _ModernCare_DBDataSet1
            // 
            this._ModernCare_DBDataSet1.DataSetName = "_ModernCare_DBDataSet1";
            this._ModernCare_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHUOCTableAdapter
            // 
            this.tHUOCTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(306, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(202, 24);
            this.labelControl1.TabIndex = 84;
            this.labelControl1.Text = "DANH SÁCH HOÁ ĐƠN";
            // 
            // _ModernCare_DBDataSet
            // 
            this._ModernCare_DBDataSet.DataSetName = "_ModernCare_DBDataSet";
            this._ModernCare_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this._ModernCare_DBDataSet;
            // 
            // modernCareDBDataSetBindingSource
            // 
            this.modernCareDBDataSetBindingSource.DataSource = this._ModernCare_DBDataSet;
            this.modernCareDBDataSetBindingSource.Position = 0;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // _ModernCare_DBDataSet3
            // 
            this._ModernCare_DBDataSet3.DataSetName = "_ModernCare_DBDataSet3";
            this._ModernCare_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            this.hOADONBindingSource.DataSource = this._ModernCare_DBDataSet3;
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
            // 
            // iDHoaDonDataGridViewTextBoxColumn
            // 
            this.iDHoaDonDataGridViewTextBoxColumn.DataPropertyName = "ID_HoaDon";
            this.iDHoaDonDataGridViewTextBoxColumn.HeaderText = "ID_HoaDon";
            this.iDHoaDonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDHoaDonDataGridViewTextBoxColumn.Name = "iDHoaDonDataGridViewTextBoxColumn";
            // 
            // iDThuNganDataGridViewTextBoxColumn
            // 
            this.iDThuNganDataGridViewTextBoxColumn.DataPropertyName = "ID_ThuNgan";
            this.iDThuNganDataGridViewTextBoxColumn.HeaderText = "ID_ThuNgan";
            this.iDThuNganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDThuNganDataGridViewTextBoxColumn.Name = "iDThuNganDataGridViewTextBoxColumn";
            // 
            // iDPhieuKhamDataGridViewTextBoxColumn
            // 
            this.iDPhieuKhamDataGridViewTextBoxColumn.DataPropertyName = "IDPhieuKham";
            this.iDPhieuKhamDataGridViewTextBoxColumn.HeaderText = "IDPhieuKham";
            this.iDPhieuKhamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPhieuKhamDataGridViewTextBoxColumn.Name = "iDPhieuKhamDataGridViewTextBoxColumn";
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            // 
            // ngayXuatDataGridViewTextBoxColumn
            // 
            this.ngayXuatDataGridViewTextBoxColumn.DataPropertyName = "NgayXuat";
            this.ngayXuatDataGridViewTextBoxColumn.HeaderText = "NgayXuat";
            this.ngayXuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayXuatDataGridViewTextBoxColumn.Name = "ngayXuatDataGridViewTextBoxColumn";
            // 
            // HOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 646);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.dgvChitiet);
            this.Controls.Add(this.labelControl1);
            this.Name = "HOADON";
            this.Text = "HOADON";
            this.Load += new System.EventHandler(this.HOADON_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ModernCare_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ModernCare_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modernCareDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ModernCare_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.DataGridView dgvChitiet;
        private System.Windows.Forms.BindingSource tHUOCBindingSource;
        private _ModernCare_DBDataSet1 _ModernCare_DBDataSet1;
        private _ModernCare_DBDataSet1TableAdapters.THUOCTableAdapter tHUOCTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private _ModernCare_DBDataSet _ModernCare_DBDataSet;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private System.Windows.Forms.BindingSource modernCareDBDataSetBindingSource;
        private _ModernCare_DBDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private _ModernCare_DBDataSet3 _ModernCare_DBDataSet3;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private _ModernCare_DBDataSet3TableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDThuNganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPhieuKhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayXuatDataGridViewTextBoxColumn;
    }
}