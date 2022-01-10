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

namespace ModernCare
{
    public partial class frmThuNgan : Form
    {
        public static string ID;
        public static string tenNV;
        public static string ID_Phieu;
        SqlConnection conn;
        SqlCommand command, sumCM;
        SqlDataAdapter adaptear = new SqlDataAdapter();
        DataTable DataTable = new DataTable();
        Int32 SumPatien;
        void loadData()
        {
            string query = "select ID_Phieu, HoTen, ID_BacSi, PHIEUKHAMBENH.NgayKham, ChanDoan, PHIEUKHAMBENH.TrieuChung from PHIEUKHAMBENH join BENHNHAN on PHIEUKHAMBENH.ID_BenhNhan = BENHNHAN.ID_BenhNhan where TrangThai = N'Đã khám'  and PHIEUKHAMBENH.NgayKham = (SELECT CAST( GETDATE() AS Date ) );";
           
            using (SqlConnection connection = new SqlConnection(DataConnection.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvPhieuKham.DataSource = table;
                dgvPhieuKham.Refresh();
                sumCM = connection.CreateCommand();
                sumCM.CommandText = "SELECT count(*) from PHIEUKHAMBENH join BENHNHAN on PHIEUKHAMBENH.ID_BenhNhan = BENHNHAN.ID_BenhNhan where TrangThai = N'Đã Khám'  and PHIEUKHAMBENH.NgayKham = (SELECT CAST( GETDATE() AS Date ) );";
                SumPatien = (Int32)sumCM.ExecuteScalar();
                countBN.Text = SumPatien.ToString();

            }
        }
        void ReLoad()
        {
            command = conn.CreateCommand();
            command.CommandText = "select ID_Phieu, HoTen, ID_BacSi, PHIEUKHAMBENH.NgayKham, ChanDoan, PHIEUKHAMBENH.TrieuChung from PHIEUKHAMBENH join BENHNHAN on PHIEUKHAMBENH.ID_BenhNhan = BENHNHAN.ID_BenhNhan WHERE TrangThai = N'Đã Khám' and PHIEUKHAMBENH.NgayKham = (SELECT CAST( GETDATE() AS Date ) );";
            adaptear.SelectCommand = command;
            DataTable.Clear();
            adaptear.Fill(DataTable);
            dgvPhieuKham.DataSource = DataTable;

        }
        public frmThuNgan()
        {
            InitializeComponent();
        }

        private void dgvPhieuKham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvPhieuKham.CurrentRow.Index;
            ID = dgvPhieuKham.Rows[i].Cells[0].Value.ToString();
            tenNV = dgvPhieuKham.Rows[i].Cells[1].Value.ToString();
            DateTime Date =  DateTime.Today.Date; 
            ID_Phieu = "HD" + DateTime.Today.Day.ToString() + ID;
            frmHoaDon hd = new frmHoaDon();
            hd.Show();
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            frmHoaDon fh = new frmHoaDon();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void frmThuNgan_Load(object sender, EventArgs e)
        {
            lbIDname.Text = frmLogin.idNV;
            loadData();
        }
    }
}
