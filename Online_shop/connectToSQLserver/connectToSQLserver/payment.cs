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
    public partial class frmpayment : Form
    {
        public frmpayment()
        {
            InitializeComponent();
        }

        private void payment_FormClosed(object sender, FormClosedEventArgs e)
        {
            new frmMainform().Show();
        }

        private void frmpayment_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from product1;";
                SqlCommand pro = new SqlCommand(sql, DataConnection.sCon);
                SqlDataReader pr = pro.ExecuteReader();

                while (pr.Read())
                {
                    int id = pr.GetInt32(0);
                    string product_name = pr.GetString(1);
                    int qty = pr.GetInt32(2);
                    int price = pr.GetInt32(3);

                    dgvproduct.Rows.Add(id, product_name, qty, price);
                }

                pr.Close();
                pro.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
