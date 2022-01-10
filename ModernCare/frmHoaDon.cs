using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ModernCare
{
    public partial class frmHoaDon : DevExpress.XtraEditors.XtraForm
    {
        int tienkham = 30000;
        SqlConnection conn = new SqlConnection(DataConnection.connectionString);
        public frmHoaDon()
        {
            
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            txtHoTen.Text = frmThuNgan.tenNV;
            txtIDPhieu.Text = frmThuNgan.ID;
            txtIDHoaDon.Text = frmThuNgan.ID_Phieu;
            txtNgayXuat.Text = DateTime.Today.ToString();
            lbTK.Text = tienkham.ToString();

            SqlConnection conn = new SqlConnection(DataConnection.connectionString);
            conn.Open();
            string checkLG_string = "select sum(DonGia*SoLuong)  from CHITIETPHIEUKHAM join THUOC on CHITIETPHIEUKHAM.ID_Thuoc = THUOC.ID_Thuoc where IDPhieuKham = '" + txtIDPhieu.Text + "'";
            SqlCommand cmd = new SqlCommand(checkLG_string, conn);
            SqlDataReader check = cmd.ExecuteReader();
            if (check.Read())
            {
                string role = check[0].ToString();
                lbTT.Text = check[0].ToString();
                int total = tienkham + int.Parse(check[0].ToString());
                lbTongTien.Text = total.ToString();
                conn.Close();
               
            }
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
          
            try
            {
                conn = new SqlConnection(DataConnection.connectionString);
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                String Request_delete = "Update BENHNHAN SET TrangThai = N'Đã Thanh toán' where HoTen = '" + txtHoTen.Text + "'";
                command.CommandText = Request_delete;
                command.ExecuteNonQuery();

                String save = "insert into HOADON values ('" +txtIDHoaDon.Text + "', '" + txtIDPhieu.Text + "', '" + frmLogin.idNV + "','" + lbTongTien.Text + "', '" + DateTime.Now + "')";
                SqlCommand savePhieu = conn.CreateCommand();
                savePhieu.CommandText = save;
                savePhieu.ExecuteNonQuery();
                MessageBox.Show("Kết quả xuất", "Xuất thành công"); 

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong the xoa" + ex.ToString()); ;
                conn.Close();
            }
        }
    }
}