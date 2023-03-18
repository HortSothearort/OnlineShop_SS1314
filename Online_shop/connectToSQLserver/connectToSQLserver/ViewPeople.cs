using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connectToSQLserver
{
    public partial class frmViewPeople : Form
    {
        public frmViewPeople()
        {
            InitializeComponent();
        }

        private void frmViewPeople_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from student;";
                SqlCommand sCom=new SqlCommand(sql,DataConnection.sCon);
                SqlDataReader sR= sCom.ExecuteReader();

                while(sR.Read())
                {
                    //string id = sR.GetValue(0)+"";
                    int id = sR.GetInt32(0);
                    string name=sR.GetString(1);
                    string gender=sR[2]+"";
                    string phone = sR[3] + "";
                    string email = sR[4] + "";

                    dgvViewPeople.Rows.Add(id,name,gender,phone,email);
                }
                sR.Close();
                sCom.Dispose();
                //DataConnection.sCon.Close();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmViewPeople_FormClosed(object sender, FormClosedEventArgs e)
        {
            new frmMainform().Show();
        }
    }
}
