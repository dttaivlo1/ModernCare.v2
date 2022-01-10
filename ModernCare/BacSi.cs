using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ModernCare
{
    public partial class BacSi : DevExpress.XtraEditors.XtraForm
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
            string query = "select * from BENHNHAN where TrangThai = N'Chờ Khám'  and NgayKham = (SELECT CAST( GETDATE() AS Date ) );";

            using (SqlConnection connection = new SqlConnection(DataConnection.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvChoKham.DataSource = table;
                dgvChoKham.Refresh();
                sumCM = connection.CreateCommand();
                sumCM.CommandText = "SELECT count(*) from BENHNHAN where TrangThai = N'Chờ Khám'  and NgayKham = (SELECT CAST( GETDATE() AS Date ) );";
                SumPatien = (Int32)sumCM.ExecuteScalar();
                countBN.Text = SumPatien.ToString();

            }
        }
        void ReLoad()
        {
            command = conn.CreateCommand();
            command.CommandText = "select *  from BENHNHAN WHERE TrangThai != N'Đã Khám' and NgayKham = (SELECT CAST( GETDATE() AS Date ) );";
            adaptear.SelectCommand = command;
            DataTable.Clear();
            adaptear.Fill(DataTable);
            dgvChoKham.DataSource = DataTable;
           
        }
        public BacSi()
        {
            InitializeComponent();
        }

        private void BacSi_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmLapPhieuKham frm = new frmLapPhieuKham();
            frm.Show();
        }

        private void IDNV_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin lg = new frmLogin();
            lg.Show();
        }

        private void dgvChoKham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvChoKham.CurrentRow.Index;
            ID = dgvChoKham.Rows[i].Cells[0].Value.ToString();
            tenNV = dgvChoKham.Rows[i].Cells[1].Value.ToString();
            ID_Phieu = "KB" + ID;
            
        }
    }
}