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
    public partial class Payments : Form
    {
        //constractor has the name like class
        // defaul constractor
        public Payments()
        {
            InitializeComponent();
        }
        // Overlaoding constractor mean nea for constact or 
                        //parametor double total
        public Payments(double total)
        {
            InitializeComponent();
            Total = total;
            txttotalamount.Text = total + ""; //c2 mean ney tha kat , 2 jong krouy
        }
        //properties
        //incaptuallation 
        public double Total { get; set; }
        public double Discounts { get; set; }
        public double Discountprice { get; set; }
        public double Paymentt { get; set; }
        public double CashReceived{ get; set; }
        public double CashReturn { get; set; }
        public PrintPreviewDialog preview { get; set; }
        //event form laod
        private void Payments_Load(object sender, EventArgs e)
        {
            txttotalamount.Text = Total.ToString("$#,##0.00");
            cbodiscount.SelectedIndex = 0;
        }

        private void cbodiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dis = cbodiscount.SelectedItem + "";
            //cut every string that stant in fron of other charator
            //mean like cut from charator ti 0 to ti 1
            dis = dis.Substring(0, dis.Length - 1);// substring stay in string
            Discounts = double.Parse(dis);
            Discountprice = Total * Discounts / 100;
            Paymentt = Total - Discountprice;
            textBox6.Text = Discountprice.ToString("$#,##0.00");
            txtpayment.Text = Paymentt.ToString("$#,##0.00");
           
        }

        private void txtcashreseived_KeyUp(object sender, KeyEventArgs e)
        {
            //!=keyenter mean we can press anykey but cann't use keyEnter 
            if (e.KeyCode != Keys.Enter)
            {
                try
                {
                    //Trim use for cut space
                    string received = txtcashreseived.Text.Trim();
                    CashReceived = double.Parse(received);
                    CashReturn = CashReceived - Paymentt;
                    txtcashreturned.Text = CashReturn.ToString("$#,##0.00");
                    if (CashReceived >= Paymentt)
                    {
                        btnpay.Enabled = true;
                    }
                    else
                        btnpay.Enabled = false;

                }
                catch (Exception ex)
                {
                    txtcashreturned.Text = "$0.00";
                    btnpay.Enabled = false;

                }
            }
            else
                btnpay_Click(sender, e);
                     
        }
        
        private void btnpay_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Pay....");
           // DialogResult = DialogResult.OK;
           // this.Dispose();
           if (chkPreview.Checked)
            {
                preview.ShowDialog();
                DialogResult = DialogResult.Cancel;

            }
           else
            {
                DialogResult = DialogResult.OK;
            }
        }

      
    }
}
