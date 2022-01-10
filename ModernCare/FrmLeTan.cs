using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

using DateTime = System.DateTime;

namespace ModernCare
{
    public partial class FrmLeTan : Form
    {
        private string tenNV;
        SqlConnection conn;
        SqlCommand command, sumCM;
        SqlDataAdapter adaptear = new SqlDataAdapter();
        DataTable DataTable = new DataTable();
        Int32 SumPatien;
        string ID;
        void loadData()
        {
            string query = "select * from BENHNHAN";
            using (SqlConnection connection = new SqlConnection(DataConnection.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvBenhNhan.DataSource = table;
                dgvBenhNhan.Refresh();
                sumCM = connection.CreateCommand();
                sumCM.CommandText = "SELECT count(*) from BENHNHAN";
                SumPatien = (Int32)sumCM.ExecuteScalar();
                lbCount.Text =SumPatien.ToString();
                connection.Close();
            }
        }
        void ReLoad()
        {
            command = conn.CreateCommand();
            command.CommandText = "select *  from BENHNHAN WHERE TrangThai != N'Đã Khám' and NgayKham = (SELECT CAST( GETDATE() AS Date ) );";
            adaptear.SelectCommand = command;
            DataTable.Clear();
            adaptear.Fill(DataTable);
            dgvBenhNhan.DataSource = DataTable;
            sumCM = conn.CreateCommand();
            sumCM.CommandText = "SELECT count(*) from BENHNHAN";
            SumPatien = (Int32)sumCM.ExecuteScalar();
            lbCount.Text = SumPatien.ToString();
        }
        public FrmLeTan()
        {
            InitializeComponent();
        }

       

        private void dgvBenhNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
            int i = dgvBenhNhan.CurrentRow.Index;
            txtID.Text = dgvBenhNhan.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dgvBenhNhan.Rows[i].Cells[1].Value.ToString();
            cbbGender.Text = checkGender((Boolean)dgvBenhNhan.Rows[i].Cells[2].Value);
            txtNamSinh.Text = dgvBenhNhan.Rows[i].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvBenhNhan.Rows[i].Cells[4].Value.ToString();
            txtTrieuChung.Text = dgvBenhNhan.Rows[i].Cells[6].Value.ToString();
            txtTrangThai.Text = dgvBenhNhan.Rows[i].Cells[7].Value.ToString();
            DateTime temp = (DateTime)dgvBenhNhan.Rows[i].Cells[5].Value;
            txtNgaykham.Text = temp.ToShortDateString();
           
        }
        public String checkGender(Boolean gender)
        {
            if (gender)
                return "Nam";
            else
                return "Nu";
        }

        private void FrmLeTan_Load(object sender, EventArgs e)
        {
            loadData();
            IDNV.Text = frmLogin.idNV;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(DataConnection.connectionString);
            conn.Open();
            command = conn.CreateCommand();
            int namsinh = Int32.Parse(txtNamSinh.Text);
            DateTime date = DateTime.Today;
            String ID = "BN" + DateTime.Today.Day.ToString() + DateTime.Today.Month.ToString() + SumPatien.ToString();
            String arr = "insert into BENHNHAN (ID_BenhNhan, HoTen, GioiTinh, NamSinh, DiaChi, NgayKham, TrieuChung, TrangThai) VALUES ('" + ID+"',N'" + txtHoTen.Text + "',N'" + checkGender(cbbGender.Text) + "','" + namsinh + "',N'" + txtDiaChi.Text + "','" + date + "',N'" + txtTrieuChung.Text + "',N'" + "Chờ Khám" + "')";
            command.CommandText = arr; 

            // command.CommandText = "insert into BENHNHAN (HoTen, GioiTinh, NamSinh,DiaChi,NgayKham, TrieuChung, TrangThai) VALUES ('"+txtName.Text+"','"+cbbGender.Text+ "','" + namsinh + "','" + txrAddress.Text + "','" + dateCome.Text + "','" + txtChanDoan.Text + "','"+"Chờ Khám"+"')'";
            command.ExecuteNonQuery();
            ReLoad();
        }

        private void btnDelêt_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(DataConnection.connectionString);
            conn.Open();
            command = conn.CreateCommand();
            String Request_delete = "Update BENHNHAN SET TrangThai = N'Chờ xoá' where ID_BenhNhan = '" + ID+"'";
            command.CommandText = Request_delete;
            command.ExecuteNonQuery();
            ReLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(DataConnection.connectionString);
            conn.Open();
            command = conn.CreateCommand();
            int namsinh = Int32.Parse(txtNamSinh.Text);
            DateTime date = DateTime.Today;
            String arr = "insert into BENHNHAN (ID_BenhNhan, HoTen, GioiTinh, NamSinh, DiaChi, NgayKham, TrieuChung, TrangThai) VALUES ('" + ID + "',N'" + txtHoTen.Text + "',N'" + checkGender(cbbGender.Text) + "','" + namsinh + "',N'" + txtDiaChi.Text + "','" + date + "',N'" + txtTrieuChung.Text + "',N'" + "Chờ Khám" + "')";
            String temp = "update  BENHNHAN SET " + " HoTen = '" + txtHoTen.Text + "'," + " GioiTinh = '" + checkGender(cbbGender.Text) + "'," + " NamSinh = '" + namsinh + "'," + " DiaChi = '" + txtDiaChi.Text + "'," + " NgayKham = '" + date + "'," + " TrieuChung = '" + txtTrieuChung.Text + "'," + " TrangThai = "   + "N'Chờ Khám" + "' Where ID_BenhNhan = '"+ txtID.Text +"'";


            command.CommandText = temp;

            // command.CommandText = "insert into BENHNHAN (HoTen, GioiTinh, NamSinh,DiaChi,NgayKham, TrieuChung, TrangThai) VALUES ('"+txtName.Text+"','"+cbbGender.Text+ "','" + namsinh + "','" + txrAddress.Text + "','" + dateCome.Text + "','" + txtChanDoan.Text + "','"+"Chờ Khám"+"')'";
            command.ExecuteNonQuery();
            ReLoad();
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(DataConnection.connectionString);
            conn.Open();
            command = conn.CreateCommand();
            command.CommandText = "select *  from BENHNHAN WHERE HoTen like '%" + txtHoTen.Text+ "%'";
            adaptear.SelectCommand = command;
            DataTable.Clear();
            adaptear.Fill(DataTable);
            dgvBenhNhan.DataSource = DataTable;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void IDNV_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin lg = new frmLogin();
            lg.Show();
        }

        private int checkGender(String gender)
        {
            if (gender.Equals("Nam"))
                return 1;
            else
                return 0;
        }
       
    }
}
