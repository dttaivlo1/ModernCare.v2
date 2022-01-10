namespace ModernCare
{
    partial class BacSi
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgvChoKham = new System.Windows.Forms.DataGridView();
            this.countBN = new DevExpress.XtraEditors.LabelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.IDNV = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoKham)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 22F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(265, 45);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Danh Sách Chờ:";
            // 
            // dgvChoKham
            // 
            this.dgvChoKham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChoKham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvChoKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChoKham.Location = new System.Drawing.Point(13, 64);
            this.dgvChoKham.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvChoKham.Name = "dgvChoKham";
            this.dgvChoKham.RowHeadersWidth = 51;
            this.dgvChoKham.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChoKham.RowTemplate.Height = 24;
            this.dgvChoKham.Size = new System.Drawing.Size(1423, 705);
            this.dgvChoKham.TabIndex = 1;
            this.dgvChoKham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChoKham_CellContentClick);
            // 
            // countBN
            // 
            this.countBN.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.countBN.Appearance.Font = new System.Drawing.Font("Tahoma", 22F);
            this.countBN.Appearance.ForeColor = System.Drawing.Color.Red;
            this.countBN.Appearance.Options.UseBackColor = true;
            this.countBN.Appearance.Options.UseFont = true;
            this.countBN.Appearance.Options.UseForeColor = true;
            this.countBN.LineColor = System.Drawing.Color.Red;
            this.countBN.Location = new System.Drawing.Point(284, 14);
            this.countBN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.countBN.Name = "countBN";
            this.countBN.Size = new System.Drawing.Size(142, 45);
            this.countBN.TabIndex = 2;
            this.countBN.Text = "Tổng BN";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(447, 27);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Tải lại dữ liệu";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(718, 27);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(142, 30);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Lập phiếu khám";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // IDNV
            // 
            this.IDNV.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDNV.Appearance.Options.UseFont = true;
            this.IDNV.Location = new System.Drawing.Point(1178, 12);
            this.IDNV.Name = "IDNV";
            this.IDNV.Size = new System.Drawing.Size(109, 24);
            this.IDNV.TabIndex = 27;
            this.IDNV.Text = "Triệu Chứng";
            this.IDNV.Click += new System.EventHandler(this.IDNV_Click);
            // 
            // BacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 782);
            this.Controls.Add(this.IDNV);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.countBN);
            this.Controls.Add(this.dgvChoKham);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "BacSi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BacSi";
            this.Load += new System.EventHandler(this.BacSi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoKham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dgvChoKham;
        private DevExpress.XtraEditors.LabelControl countBN;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl IDNV;
    }
}