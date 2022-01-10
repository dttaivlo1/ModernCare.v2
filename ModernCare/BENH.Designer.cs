namespace ModernCare
{
    partial class BENH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BENH));
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnADD = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._ModernCare_DBDataSet2 = new ModernCare._ModernCare_DBDataSet2();
            this.bENHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bENHTableAdapter = new ModernCare._ModernCare_DBDataSet2TableAdapters.BENHTableAdapter();
            this.iDBenhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenBenhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ModernCare_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(109, 67);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.PasswordChar = '*';
            this.textEdit1.Size = new System.Drawing.Size(246, 30);
            this.textEdit1.TabIndex = 69;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(13, 70);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(84, 24);
            this.labelControl5.TabIndex = 68;
            this.labelControl5.Text = "Tên bệnh";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(108, 19);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuong.Size = new System.Drawing.Size(128, 30);
            this.txtSoLuong.TabIndex = 67;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(12, 22);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(77, 24);
            this.labelControl6.TabIndex = 66;
            this.labelControl6.Text = "Mã Bệnh";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(13, 133);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(97, 46);
            this.simpleButton1.TabIndex = 86;
            this.simpleButton1.Text = "Cập nhật";
            // 
            // btnDel
            // 
            this.btnDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.Image")));
            this.btnDel.Location = new System.Drawing.Point(139, 133);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(97, 46);
            this.btnDel.TabIndex = 85;
            this.btnDel.Text = "Xoá";
            // 
            // btnADD
            // 
            this.btnADD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnADD.ImageOptions.Image")));
            this.btnADD.Location = new System.Drawing.Point(258, 133);
            this.btnADD.Margin = new System.Windows.Forms.Padding(4);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(97, 46);
            this.btnADD.TabIndex = 84;
            this.btnADD.Text = "Thêm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBenhDataGridViewTextBoxColumn,
            this.tenBenhDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bENHBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(343, 304);
            this.dataGridView1.TabIndex = 87;
            // 
            // _ModernCare_DBDataSet2
            // 
            this._ModernCare_DBDataSet2.DataSetName = "_ModernCare_DBDataSet2";
            this._ModernCare_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bENHBindingSource
            // 
            this.bENHBindingSource.DataMember = "BENH";
            this.bENHBindingSource.DataSource = this._ModernCare_DBDataSet2;
            // 
            // bENHTableAdapter
            // 
            this.bENHTableAdapter.ClearBeforeFill = true;
            // 
            // iDBenhDataGridViewTextBoxColumn
            // 
            this.iDBenhDataGridViewTextBoxColumn.DataPropertyName = "ID_Benh";
            this.iDBenhDataGridViewTextBoxColumn.HeaderText = "ID_Benh";
            this.iDBenhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDBenhDataGridViewTextBoxColumn.Name = "iDBenhDataGridViewTextBoxColumn";
            // 
            // tenBenhDataGridViewTextBoxColumn
            // 
            this.tenBenhDataGridViewTextBoxColumn.DataPropertyName = "TenBenh";
            this.tenBenhDataGridViewTextBoxColumn.HeaderText = "TenBenh";
            this.tenBenhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenBenhDataGridViewTextBoxColumn.Name = "tenBenhDataGridViewTextBoxColumn";
            // 
            // BENH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 545);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.labelControl6);
            this.Name = "BENH";
            this.Text = "BENH";
            this.Load += new System.EventHandler(this.BENH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ModernCare_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.SimpleButton btnADD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _ModernCare_DBDataSet2 _ModernCare_DBDataSet2;
        private System.Windows.Forms.BindingSource bENHBindingSource;
        private _ModernCare_DBDataSet2TableAdapters.BENHTableAdapter bENHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBenhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBenhDataGridViewTextBoxColumn;
    }
}