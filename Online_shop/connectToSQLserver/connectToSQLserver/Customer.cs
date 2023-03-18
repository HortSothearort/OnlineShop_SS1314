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
    public partial class frmcustomer : Form
    {
        public frmcustomer()
        {
            InitializeComponent();
        }
                                                    //object text"e" under this it jab information from key that we press
        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(!char.IsLetter(e.KeyChar)&& !char.IsControl(e.KeyChar)&&!char.IsWhiteSpace(e.KeyChar))
            e.Handled = true;//this it we close all press key that we press
        }

        private void txtage_KeyPress(object sender, KeyPressEventArgs e)
        {
             if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
                 e.Handled = true;
            /* if(!char.IsNumber(e.KeyChar))
                  e.Handled = true;*/
           /* if (!(e.KeyChar >= 48 && e.KeyChar <= 57)&&(e.KeyChar!=8))
                e.Handled = true;*/
        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetterOrDigit(e.KeyChar)&& e.KeyChar!=8 && e.KeyChar!=64 && e.KeyChar !=46 &&e.KeyChar!=95)
            e.Handled = true;
        }

        private void frmcustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
