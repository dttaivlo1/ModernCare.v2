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
    public partial class BENH : Form
    {
        public BENH()
        {
            InitializeComponent();
        }

        private void BENH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_ModernCare_DBDataSet2.BENH' table. You can move, or remove it, as needed.
            this.bENHTableAdapter.Fill(this._ModernCare_DBDataSet2.BENH);

        }
    }
}
