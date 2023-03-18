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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            cboAuthentication.SelectedIndex = 0;
            txtServerName.Text = "localhost";
        }

        private void cboAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index=cboAuthentication.SelectedIndex;
            if(index == 0)
            {
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUserName.Enabled = true;
                txtPassword.Enabled = true;
            }
               
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sName = txtServerName.Text;
                string dbName = "Lay";
                string uName = txtUserName.Text;
                string pword = txtPassword.Text;
                int index = cboAuthentication.SelectedIndex;
                if (index == 0)
                    DataConnection.ConnectDB(sName, dbName);
                else 
                    DataConnection.ConnectDB(sName, dbName, uName, pword);
                //MessageBox.Show("Connection sucessful");
                new frmMainform().Show();
                //this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtServerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
