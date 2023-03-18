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
    public partial class frminsertproduct : Form
    {
        public frminsertproduct()
        {
            InitializeComponent();
        }

        private List<string> arrcID = new List<string>();
        private void frminsertproduct_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select* from category;";
                SqlCommand scom = new SqlCommand(sql, DataConnection.sCon);
                SqlDataReader rcategory = scom.ExecuteReader();
                while(rcategory.Read())
                {
                    string cID = rcategory[0].ToString();
                    string cname = rcategory[1].ToString();
                    arrcID.Add(cID);
                    cboCategory.Items.Add(cname);
                }
                rcategory.Close();
                scom.Dispose();
                cboCategory.SelectedIndex = 0;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                int index = cboCategory.SelectedIndex;
                txtcID.Text = arrcID[index];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {

                string barcode = txtbar.Text.Trim();
                string pname = txtpro.Text.Trim();
                int qty = int.Parse(txtqty.Text);
                float priceIn = float.Parse(txtpriceIn.Text);
                float priceOut = float.Parse(txtpriceOut.Text);
                int cId = int.Parse(txtcID.Text);

                string sql = "Insert Into Product1 Values('" + barcode + "','" +
                    pname + "','" + qty + "','" + priceIn + "','" + priceOut + "'," + cId +",'"+ destphoto+ "')";
                SqlCommand scom = new SqlCommand(sql, DataConnection.sCon);
                scom.ExecuteNonQuery();
                scom.Dispose();
                MessageBox.Show("Product intered successfully");
                this.Dispose();
                new frminsertproduct().Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string destphoto;
        private void picphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog fp = new OpenFileDialog();
            DialogResult dr= fp.ShowDialog();
            if(dr==DialogResult.OK)
            {
                destphoto = "products\\" + Path.GetFileName(fp.FileName);
                Image im = Image.FromFile(fp.FileName);
                picphoto.Image = im;
            }
        }
    }
}
