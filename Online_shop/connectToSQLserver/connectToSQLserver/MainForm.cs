
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connectToSQLserver
{
    public partial class frmMainform : Form
    {
        public frmMainform()
        {
            InitializeComponent();
        }

        private void frmMainform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnviewpeople_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frmViewPeople().ShowDialog();
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frmpayment().ShowDialog();
        }

        private void btnluckydraw_Click(object sender, EventArgs e)
        {
            new frmLuckyDraw().Show();
        }

        private void tbnpro_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frminsertproduct().Show();
        }

        private void frmMainform_Load(object sender, EventArgs e)
        {

        }

        private void btnOrderproducts_Click(object sender, EventArgs e)
        {
            new frmOrderproducts().Show();
        }

        private void showproduct_Click(object sender, EventArgs e)
        {
            new showProduct().Show();
        }
    }
}
