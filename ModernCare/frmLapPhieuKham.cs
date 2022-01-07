using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ModernCare
{
    public partial class frmLapPhieuKham : Form
    {
        private string tenNV;
        string IDThuoc;
        SqlConnection conn = new SqlConnection(DataConnection.connectionString);
        SqlCommand command,command2, sumCM;
        SqlDataAdapter adaptear = new SqlDataAdapter();
        DataTable DataTable = new DataTable();
        Int32 SumThuoc;
        string ID, cellSelected;

        void loadData()
        {
            string query = "select * from CHITIETPHIEUKHAM WHERE IDPhieuKham = '"+ txtIDPhieu.Text + "'";
            using (SqlConnection connection = new SqlConnection(DataConnection.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvChitiet.DataSource = DataTable;
                dgvChitiet.Refresh();
                sumCM = connection.CreateCommand();
                ID = txtIDPhieu.Text;
                sumCM.CommandText = "SELECT count(*) from CHITIETPHIEUKHAM where IDPhieuKham = '"+ID+"'";
                SumThuoc = (Int32)sumCM.ExecuteScalar();
                lbCount.Text = SumThuoc.ToString();
                connection.Close();
            }
        }
        void ReLoad()
        {
            command = conn.CreateCommand();
            command.CommandText = "select * from CHITIETPHIEUKHAM WHERE IDPhieuKham = '" + txtIDPhieu.Text + "'";
            adaptear.SelectCommand = command;
            DataTable.Clear();
            adaptear.Fill(DataTable);
            dgvChitiet.DataSource = DataTable;
            sumCM = conn.CreateCommand();
            sumCM.CommandText = "SELECT count(*) from CHITIETPHIEUKHAM WHERE IDPhieuKham = '" + txtIDPhieu.Text + "'";
            SumThuoc = (Int32)sumCM.ExecuteScalar();
            lbCount.Text = SumThuoc.ToString();
        }

        public frmLapPhieuKham()
        {
            InitializeComponent();
        }
        public void bindData()
        {   
            //combobox bệnh
            String query = "select * from BENH";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);//SQL là câu truy vấn bảng trong cơ sở dữ liệu, cn là connection đến cơ sở dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbBenh.DisplayMember = "TenBenh";//Word là tên trường bạn muốn hiển thị trong combobox
            cbbBenh.ValueMember = "TenBenh";
            cbbBenh.DataSource = dt;
            //combobox thuốc
            String query_Thuoc = "select * from THUOC";
            SqlDataAdapter da_Thuoc = new SqlDataAdapter(query_Thuoc, conn);//SQL là câu truy vấn bảng trong cơ sở dữ liệu, cn là connection đến cơ sở dữ liệu
            DataTable dt_Thuoc = new DataTable();
            da_Thuoc.Fill(dt_Thuoc);
            cbbThuoc.DisplayMember = "TenThuoc";//Word là tên trường bạn muốn hiển thị trong combobox
            cbbThuoc.ValueMember = "TenThuoc";
            cbbThuoc.DataSource = dt_Thuoc;
            cbbThuoc.Text = "--Select--";
            txtHoTen.Text = BacSi.tenNV;
            txtID.Text = BacSi.ID;
            txtIDPhieu.Text = BacSi.ID_Phieu;
        }

        private void cbbThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DataConnection.connectionString);
            
                conn.Open();
                string ID = cbbThuoc.Text;
                string bindCD = "Select TenCachDung from THUOC JOIN CACHDUNG ON THUOC.CachDung = CACHDUNG. ID_CachDung where THUOC.TenThuoc = '"+ID+"'";
                SqlCommand cmd = new SqlCommand(bindCD, conn);
                SqlDataReader check = cmd.ExecuteReader();
               while (check.Read())
            { 
                string temp   = (string)check[0].ToString();
                txtCachDung.Text = temp;
                   
            }
                    
                    conn.Close();
                   

        }

        private void dgvChitiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvChitiet.CurrentRow.Index;
            cellSelected = dgvChitiet.Rows[i].Cells[1].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(DataConnection.connectionString);
                conn.Open();
                command = conn.CreateCommand();
                int CellSelected = int.Parse(cellSelected);
                String Request_delete = "delete CHITIETPHIEUKHAM  where ID_ChiTietPhieu = " + cellSelected;
                command.CommandText = Request_delete;
                command.ExecuteNonQuery();
                ReLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong the xoa" + ex.ToString()); ;
                conn.Close();
            }
            

            }

       

        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(DataConnection.connectionString);
                conn.Open();
               
                command2 = conn.CreateCommand();
                String arrIDThuoc = "Select ID_Thuoc from THUOC where TenThuoc = '" + cbbThuoc.Text + "'";


                SqlCommand cmd = new SqlCommand(arrIDThuoc, conn);
                SqlDataReader check = cmd.ExecuteReader();
                while (check.Read())
                {
                    string temp = (string)check[0].ToString().Trim();
                    IDThuoc = temp;

                }

                int sl = int.Parse(txtSoLuong.Text);
                conn.Close();
                conn.Open();
                command = conn.CreateCommand();
                String arr = "insert into CHITIETPHIEUKHAM (IDPhieuKham, ID_Thuoc, SoLuong) VALUES ('" + txtIDPhieu.Text + "','" + IDThuoc + "','" + txtSoLuong.Text + "')";
                command.CommandText = arr;

                // command.CommandText = "insert into BENHNHAN (HoTen, GioiTinh, NamSinh,DiaChi,NgayKham, TrieuChung, TrangThai) VALUES ('"+txtName.Text+"','"+cbbGender.Text+ "','" + namsinh + "','" + txrAddress.Text + "','" + dateCome.Text + "','" + txtChanDoan.Text + "','"+"Chờ Khám"+"')'";
                command.ExecuteNonQuery();
                
                ReLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập không thành công" + ex.ToString()); ;
                conn.Close();
            }
              

           
        }

        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            bindData();
        }
    }
}
