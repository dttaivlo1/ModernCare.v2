using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernCare
{
    public partial class NHANVIEN : Form
    {
        public NHANVIEN()
        {
            InitializeComponent();
        }

        private void NHANVIEN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_ModernCare_DBDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this._ModernCare_DBDataSet.NHANVIEN);

        }
    }
}
