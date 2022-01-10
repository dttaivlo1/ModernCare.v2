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
    public partial class HOADON : Form
    {
        public HOADON()
        {
            InitializeComponent();
        }

        private void HOADON_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_ModernCare_DBDataSet3.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this._ModernCare_DBDataSet3.HOADON);

        }
    }
}
