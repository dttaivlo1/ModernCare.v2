namespace ModernCare
{
    partial class frmLapPhieuKham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLapPhieuKham));
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbbBenh = new System.Windows.Forms.ComboBox();
            this.txtIDPhieu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbbThuoc = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.btnADD = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.txtCachDung = new DevExpress.XtraEditors.TextEdit();
            this.btnXuatPhieu = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.dgvChitiet = new System.Windows.Forms.DataGridView();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lbCount = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCachDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(176, 9);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(125, 30);
            this.txtID.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(127, 24);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Mã Bệnh nhân";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(443, 50);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(95, 24);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Chẩn đoán";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(407, 6);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Properties.Appearance.Options.UseFont = true;
            this.txtHoTen.Properties.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(381, 30);
            this.txtHoTen.TabIndex = 21;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(319, 10);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 24);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "Họ Tên";
            // 
            // cbbBenh
            // 
            this.cbbBenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBenh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBenh.FormattingEnabled = true;
            this.cbbBenh.Location = new System.Drawing.Point(552, 47);
            this.cbbBenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbBenh.Name = "cbbBenh";
            this.cbbBenh.Size = new System.Drawing.Size(235, 32);
            this.cbbBenh.TabIndex = 22;
            // 
            // txtIDPhieu
            // 
            this.txtIDPhieu.Location = new System.Drawing.Point(176, 53);
            this.txtIDPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDPhieu.Name = "txtIDPhieu";
            this.txtIDPhieu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPhieu.Properties.Appearance.Options.UseFont = true;
            this.txtIDPhieu.Properties.ReadOnly = true;
            this.txtIDPhieu.Size = new System.Drawing.Size(125, 30);
            this.txtIDPhieu.TabIndex = 24;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 57);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(138, 24);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "Mã Phiếu Khám";
            // 
            // cbbThuoc
            // 
            this.cbbThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThuoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThuoc.FormattingEnabled = true;
            this.cbbThuoc.Location = new System.Drawing.Point(121, 166);
            this.cbbThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbThuoc.Name = "cbbThuoc";
            this.cbbThuoc.Size = new System.Drawing.Size(324, 32);
            this.cbbThuoc.TabIndex = 27;
            this.cbbThuoc.SelectedIndexChanged += new System.EventHandler(this.cbbThuoc_SelectedIndexChanged);
            this.cbbThuoc.SelectionChangeCommitted += new System.EventHandler(this.cbbThuoc_SelectedIndexChanged);
            this.cbbThuoc.MouseLeave += new System.EventHandler(this.cbbThuoc_SelectedIndexChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 169);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 24);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "Thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Thông tin kê thuốc";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(483, 169);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(78, 24);
            this.labelControl6.TabIndex = 29;
            this.labelControl6.Text = "Số lượng";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(12, 226);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(93, 24);
            this.labelControl7.TabIndex = 31;
            this.labelControl7.Text = "Cách dùng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(584, 166);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuong.Size = new System.Drawing.Size(71, 30);
            this.txtSoLuong.TabIndex = 33;
            // 
            // btnADD
            // 
            this.btnADD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnADD.ImageOptions.Image")));
            this.btnADD.Location = new System.Drawing.Point(691, 169);
            this.btnADD.Margin = new System.Windows.Forms.Padding(4);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(97, 46);
            this.btnADD.TabIndex = 34;
            this.btnADD.Text = "Thêm";
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnDel
            // 
            this.btnDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.Image")));
            this.btnDel.Location = new System.Drawing.Point(691, 222);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(97, 46);
            this.btnDel.TabIndex = 35;
            this.btnDel.Text = "Xoá";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtCachDung
            // 
            this.txtCachDung.Location = new System.Drawing.Point(117, 223);
            this.txtCachDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCachDung.Name = "txtCachDung";
            this.txtCachDung.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCachDung.Properties.Appearance.Options.UseFont = true;
            this.txtCachDung.Properties.ReadOnly = true;
            this.txtCachDung.Size = new System.Drawing.Size(533, 30);
            this.txtCachDung.TabIndex = 36;
            // 
            // btnXuatPhieu
            // 
            this.btnXuatPhieu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatPhieu.ImageOptions.Image")));
            this.btnXuatPhieu.Location = new System.Drawing.Point(605, 715);
            this.btnXuatPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatPhieu.Name = "btnXuatPhieu";
            this.btnXuatPhieu.Size = new System.Drawing.Size(183, 52);
            this.btnXuatPhieu.TabIndex = 37;
            this.btnXuatPhieu.Text = "Xuất phiếu khám";
            this.btnXuatPhieu.Click += new System.EventHandler(this.btnXuatPhieu_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(407, 715);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(183, 52);
            this.simpleButton4.TabIndex = 38;
            this.simpleButton4.Text = "Huỷ Phiếu";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // dgvChitiet
            // 
            this.dgvChitiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChitiet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvChitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChitiet.Location = new System.Drawing.Point(11, 274);
            this.dgvChitiet.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChitiet.Name = "dgvChitiet";
            this.dgvChitiet.RowHeadersWidth = 51;
            this.dgvChitiet.Size = new System.Drawing.Size(777, 425);
            this.dgvChitiet.TabIndex = 39;
            this.dgvChitiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChitiet_CellContentClick);
            this.dgvChitiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChitiet_CellContentClick);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(15, 715);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(133, 24);
            this.labelControl8.TabIndex = 40;
            this.labelControl8.Text = "Tổng số thuốc:";
            // 
            // lbCount
            // 
            this.lbCount.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbCount.Appearance.Options.UseFont = true;
            this.lbCount.Appearance.Options.UseForeColor = true;
            this.lbCount.Location = new System.Drawing.Point(164, 715);
            this.lbCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(78, 24);
            this.lbCount.TabIndex = 41;
            this.lbCount.Text = "Số lượng";
            // 
            // frmLapPhieuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 782);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.dgvChitiet);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.btnXuatPhieu);
            this.Controls.Add(this.txtCachDung);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbThuoc);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtIDPhieu);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbbBenh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLapPhieuKham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLapHoaDon";
            this.Load += new System.EventHandler(this.frmLapHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCachDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cbbBenh;
        private DevExpress.XtraEditors.TextEdit txtIDPhieu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cbbThuoc;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraEditors.SimpleButton btnADD;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.TextEdit txtCachDung;
        private DevExpress.XtraEditors.SimpleButton btnXuatPhieu;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.DataGridView dgvChitiet;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl lbCount;
    }
}