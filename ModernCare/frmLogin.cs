using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModernCare
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
       public static string idNV;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DataConnection.connectionString);
            try
            {
                conn.Open();
                string tk = txtUsername.Text;
                string mk = txtPassword.Text;   
                string checkLG_string = "Select Role, ID_NhanVien  from NHANVIEN where Username = '" + tk + "' and Password = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(checkLG_string, conn);
                SqlDataReader check = cmd.ExecuteReader();
                if (check.Read())
                {
                    string role = check[0].ToString();
                    idNV = check[1].ToString();
                    conn.Close();
                    switch (role)
                    {
                        case "4":
                            this.Hide();
                            frmAdmin frmAdmin = new frmAdmin();
                            frmAdmin.Show();

                            break;

                        case "3":
                            this.Hide();
                            frmThuNgan TN = new frmThuNgan();
                            TN.Show();
                            break;
                        case "2":
                            this.Hide();
                            BacSi bac = new BacSi();
                            bac.Show();
                            break;
                        case "1":
                            this.Hide();
                            FrmLeTan frmLeTan = new FrmLeTan();
                            frmLeTan.Show();

                            break;
                    }
                }
                else
                    MessageBox.Show("Sai tên thông tin", "Thất bại", MessageBoxButtons.OK);
                conn.Close();
            }
            catch (Exception )
            {
                MessageBox.Show("Đăng nhập không thành công");
                conn.Close();

            }



        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
