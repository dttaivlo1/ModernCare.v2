using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraEditors;

namespace ModernCare
{
    public partial class frmAdmin : DevExpress.XtraEditors.XtraForm
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            THUOC t = new THUOC();
            t.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            BENH b = new BENH();
            b.Show();
        }
    }
}