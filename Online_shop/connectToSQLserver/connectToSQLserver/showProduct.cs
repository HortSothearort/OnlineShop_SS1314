using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connectToSQLserver
{
    public partial class showProduct : Form
    {
        public showProduct()
        {
            InitializeComponent();
        }
        private void showProduct_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from product1;";
                SqlCommand sCom = new SqlCommand(sql, DataConnection.sCon);
                SqlDataReader r = sCom.ExecuteReader();
                int x = 0, y = 1;
                while(r.Read())
                {
                    int id = int.Parse(r[0] + "");
                    string pname = r[2] + "";
                    int instock = int.Parse(r[3] + "");
                    string price = double.Parse(r[5] + "").ToString("c2");
                    Image im=Image.FromFile(@""+r[7]);
                    ProductControl p = new ProductControl(id, pname, im);

                    tableLayoutPanel1.Controls.Add(p, y, x);
                    y++;
                    if(y>4)
                    {
                        y = 1;
                        x++;
                    }
                }
                r.Close();
                sCom.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }



}
