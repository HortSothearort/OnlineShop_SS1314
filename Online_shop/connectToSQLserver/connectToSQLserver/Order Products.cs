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
    public partial class frmOrderproducts : Form
    {
        public frmOrderproducts()
        {
            InitializeComponent();
        }
        private List<Orderdetail> OrderList = new List<Orderdetail>();
        private int checkproductID(int ID)
        {
            for(int i=0; i<OrderList.Count;i++)
            {
                Orderdetail obj = OrderList[i];
                if (obj.pID == ID)
                    return i;
            }
            return -1;
        }
       /* private double total(double ttotal)
        {
            OrderList = 
        }*/
        private bool IsProductsExist(string barCode)
        {
            string sql = "Select*from product1 where barcode='" + barCode + "';";
            SqlCommand scom = new SqlCommand(sql, DataConnection.sCon);
            SqlDataReader pproduct = scom.ExecuteReader();
            if(pproduct.Read())
            {
                string pID = pproduct[0] + "";
                int num = dgvdata.Rows.Count + 1;
                string pname = pproduct[2] + "";
                double price = double.Parse(pproduct[5] + "");
                double amt;
                int qty = 1;
                int index = checkproductID(int.Parse(pID));
                if(index>=0)
                {
                    qty = OrderList[index].qty + 1;
                    amt = qty * price;
                    dgvdata.Rows[index].Cells[2].Value = qty;
                    dgvdata.Rows[index].Cells[4].Value = amt.ToString("$#,##0.00"); 
                    OrderList[index].qty = qty;
                }
                else
                {
                double amount = qty * price;
                dgvdata.Rows.Add(num, pname, qty, price.ToString("$#,##0.00"),
                    amount.ToString("$#,##0.00"));

                Orderdetail obj = new Orderdetail(int.Parse(pID),qty,price);
                OrderList.Add(obj);
                }
                pproduct.Close();
                scom.Dispose();
                return true;
            }
            else
            {
                pproduct.Close();
                scom.Dispose();
                return false;

            }
        
        }
        private double total()
        {
            double t = 0;
            foreach (Orderdetail temp in OrderList)
                t += temp.qty * temp.price;
            return t;
        }
        private void txtbarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //keyenter 
            {   
                string barcode = txtbarCode.Text;

                if(IsProductsExist(barcode))
                {
                    txtbarCode.Clear();
                    txtTotal.Text = total().ToString("$,##0.00");
                }
                else
                {
                    //MessageBox.Show("Product is not availble");
                }
            }
        }

        // funtion private
        string Seller;
        string OId;
        string orderDatee;
        string orderTimee;
        private string InsertOrder(double Discounts)
        {
             orderDatee = DateTime.Now.ToString("yyyy-MM-dd");
             orderTimee = DateTime.Now.ToString("HH:MM:ss");
           Seller = DataConnection.Seller;
            //
            string sql = "INSERT into order1 VALUES('"+orderDatee+"','"+orderTimee+"',"+Discounts+",'"+Seller+"');";

            SqlCommand scom = new SqlCommand(sql, DataConnection.sCon);
            scom.ExecuteNonQuery();

            sql = "select scope_IDENTITY()";
            scom = new SqlCommand(sql, DataConnection.sCon);
            SqlDataReader ID = scom.ExecuteReader();
           OId = "";
            if (ID.Read())
                OId = ID[0] + "";
            ID.Close();
            scom.Dispose();
            return OId;
                
        }
        private void InsertOrderDetail(String OId)
        {
            foreach(Orderdetail item in OrderList)
            {
                string pID = item.pID + "";
                string Qty = item.pID + "";
                string price = item.price + "";
                string sql = "Insert Into orderDetail1 values" +
                    "(" + pID + "," + Qty + "," + price + ");";
                SqlCommand sCom = new SqlCommand(sql, DataConnection.sCon);
                sCom.ExecuteNonQuery();
                sCom.Dispose();
            }
        }
        private void updateStock()
        {
            foreach(Orderdetail item in OrderList)
            {
                int pID = item.pID;
                int qty = item.qty;
                string sql = "update Product1 set inStock-="+qty+" where pID="+pID+";";
                SqlCommand scom = new SqlCommand(sql, DataConnection.sCon);
                scom.ExecuteNonQuery();
                scom.Dispose();
            }         
        }
        Payments p;
        private void btnpayment_Click(object sender, EventArgs e)
        {
             p = new Payments(total());
            // p.ShowDialog();
            //diferent of .show that dailogResult can use for update  or insert new product or new activity
            p.preview = printPreviewDialog;
            if(p.ShowDialog()== DialogResult.OK)
            {

                InsertOrder(p.Discounts);
                updateStock();
                printPreviewDialog.ShowDialog();
                //printDocument.Print();
            
            
            //clear for new orders
                OrderList = new List<Orderdetail>();
                dgvdata.Rows.Clear();
                
                txtTotal.Text = "$0.00";
            }
        }
        //
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int y = 0;
            //Image logo = Image.FromFile("C:\\Users\\mengsoklay\\Desktop\\MengSoklay SS13.14\\connectToSQLserver\\connectToSQLserver\\bin\\Debug\\logo1.png");
            Image logo = Image.FromFile(Directory.GetCurrentDirectory() + "\\img\\logo1.png");
            e.Graphics.DrawImage(logo, 350, 0, 200, 200);
            y += 230;
            //use for pouse string;
            e.Graphics.DrawString("FoodPanda Promotion", new Font("", 20), Brushes.Red, new Point(560, y));
            y += 10 ;
            e.Graphics.DrawString($"OderID: {OId}", new Font("", 15),Brushes.Green,new Point(0, y));
            y += 20;
            e.Graphics.DrawString($"Seller: {Seller}", new Font("", 20), Brushes.Blue, new Point(560, y));
            y += 30;
            e.Graphics.DrawString($"DESCRIPTION             QUANTITY         PRICE             AMOUNT",
                new Font("", 20), Brushes.Blue, new Point(0, y));
            y += 40;
            foreach(DataGridViewRow row in dgvdata.Rows)
            {
                string pName = row.Cells[1].Value+"";
                e.Graphics.DrawString($"{pName}",new Font("",20), Brushes.Blue, new Point(0, y));
                string qty = row.Cells[2].Value + "";
                e.Graphics.DrawString($"{qty}", new Font("", 20), Brushes.Blue, new Point(300, y));
                string price = row.Cells[3].Value + "";
                e.Graphics.DrawString($"{price}", new Font("", 20), Brushes.Red, new Point(500, y));
                string amount = row.Cells[4].Value + "";
                e.Graphics.DrawString($"{amount}", new Font("", 20), Brushes.Red, new Point(670, y));

                y += 25;
            }

            // e.Graphics.DrawString("=================================================================")
            //, new Font("", 20) ,new Point(0, y);
            e.Graphics.DrawString("_______________________________________________________________________",
                new Font("", 20), Brushes.Purple, new Point(0, y));
            y += 30;
            e.Graphics.DrawString("Total Amount:", new Font("", 20), Brushes.Blue, new Point(0, y));
            e.Graphics.DrawString(total().ToString("c2"), new Font("", 20), Brushes.Red, new Point(670, y));
            y += 30;
            e.Graphics.DrawString("Discount:", new Font("", 20), Brushes.Blue, new Point(0, y));
            e.Graphics.DrawString(p.Discounts+"% ", new Font("", 20), Brushes.Red, new Point(670, y));

            y += 30;
            e.Graphics.DrawString($"Discount price:", new Font("", 20), Brushes.Blue, new Point(0, y));
            e.Graphics.DrawString(p.Discountprice.ToString("c2"), new Font("", 20), Brushes.Red, new Point(670, y));

            y += 30;
            e.Graphics.DrawString("Payment:", new Font("", 20), Brushes.Blue, new Point(0, y));
            e.Graphics.DrawString(p.Paymentt.ToString("c2"), new Font("", 20), Brushes.Red, new Point(670, y));

            y += 30;
            e.Graphics.DrawString("Cash Receive:", new Font("", 20), Brushes.Blue, new Point(0, y));
            e.Graphics.DrawString(p.CashReceived .ToString("c2"), new Font("", 20), Brushes.Red, new Point(670, y));

            y += 30;
            e.Graphics.DrawString("Cash Return:", new Font("", 20), Brushes.Blue, new Point(0, y));
            e.Graphics.DrawString(p.CashReturn .ToString("c2"), new Font("", 20), Brushes.Red, new Point(670, y));
            e.Graphics.DrawString("________________________________________________________________________",
                new Font("", 20), Brushes.Purple, new Point(0, y));
            y += 50;
            e.Graphics.DrawString("OrderDate:", new Font("", 20), Brushes.DarkBlue, new Point(0, y));
            e.Graphics.DrawString(orderDatee, new Font("", 20), Brushes.DarkBlue, new Point(670, y));
            y += 35;
            e.Graphics.DrawString("OrderTime:", new Font("", 20), Brushes.DarkBlue, new Point(0, y));
            e.Graphics.DrawString(orderTimee, new Font("", 20), Brushes.DarkBlue, new Point(670, y));





        }
    }
}
