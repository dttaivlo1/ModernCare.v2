namespace ModernCare
{
    partial class frmThuNgan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThuNgan));
            this.btnTaoHD = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.countBN = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgvPhieuKham = new System.Windows.Forms.DataGridView();
            this.lbIDname = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuKham)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoHD.ImageOptions.Image")));
            this.btnTaoHD.Location = new System.Drawing.Point(637, 11);
            this.btnTaoHD.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(158, 45);
            this.btnTaoHD.TabIndex = 8;
            this.btnTaoHD.Text = "Lập hoá đơn";
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(448, 11);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(158, 45);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Tải lại dữ liệu";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.countBN.Location = new System.Drawing.Point(285, 13);
            this.countBN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.countBN.Name = "countBN";
            this.countBN.Size = new System.Drawing.Size(142, 45);
            this.countBN.TabIndex = 6;
            this.countBN.Text = "Tổng BN";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 22F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(265, 45);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Danh Sách Chờ:";
            // 
            // dgvPhieuKham
            // 
            this.dgvPhieuKham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhieuKham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuKham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPhieuKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuKham.Location = new System.Drawing.Point(13, 63);
            this.dgvPhieuKham.Name = "dgvPhieuKham";
            this.dgvPhieuKham.RowHeadersWidth = 51;
            this.dgvPhieuKham.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPhieuKham.RowTemplate.Height = 24;
            this.dgvPhieuKham.Size = new System.Drawing.Size(1721, 693);
            this.dgvPhieuKham.TabIndex = 9;
            this.dgvPhieuKham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuKham_CellContentClick);
            // 
            // lbIDname
            // 
            this.lbIDname.Location = new System.Drawing.Point(1585, 26);
            this.lbIDname.Name = "lbIDname";
            this.lbIDname.Size = new System.Drawing.Size(38, 16);
            this.lbIDname.TabIndex = 10;
            this.lbIDname.Text = "tên NV";
            // 
            // frmThuNgan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1746, 768);
            this.Controls.Add(this.lbIDname);
            this.Controls.Add(this.dgvPhieuKham);
            this.Controls.Add(this.btnTaoHD);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.countBN);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmThuNgan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThuNgan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThuNgan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuKham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTaoHD;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.LabelControl countBN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dgvPhieuKham;
        private DevExpress.XtraEditors.LabelControl lbIDname;
    }
}