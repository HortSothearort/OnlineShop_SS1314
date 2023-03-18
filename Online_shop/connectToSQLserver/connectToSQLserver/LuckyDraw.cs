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
    public partial class frmLuckyDraw : Form
    {
        public frmLuckyDraw()
        {
            InitializeComponent();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            if (btnstart.Text == "Start")
            {
                if (arr.Count>0)
                {
                    timer.Start();
                    btnstart.Text = "Stop";
                }
                else
                    MessageBox.Show("No More People");
            }
            else
            {
                timer.Stop();
                btnstart.Text = "Start";
                listBox1.Items.Add(arr[index].Phone);
                arrWinner.Add(arr[index]);
                arr.RemoveAt(index);
            }
        }
        private List<student> arr;
        private List<student> arrWinner;
        private void frmLuckyDraw_Load(object sender, EventArgs e)
        {
            arr = new List<student>();
            arrWinner = new List<student>();
            string sql = "select * from student;";
            SqlCommand sCom = new SqlCommand(sql, DataConnection.sCon);
            SqlDataReader dpeople = sCom.ExecuteReader();

            while (dpeople.Read())
            {
                string id = dpeople.GetValue(0)+"";
                //int id = dpeople.GetInt32(0);
                string name = dpeople.GetString(1);
                string gender = dpeople[2] + "";
                string phone = dpeople[3] + "";
                string email = dpeople[4] + "";
                student s = new student(id, name, gender, phone, email);
                arr.Add(s);
                
            }
            dpeople.Close();
            sCom.Dispose();
            //DataConnection.sCon.Close();
        }
        int index;
        private void timer_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            index = r.Next(arr.Count());
            string phone = arr[index].Phone;
            txtnumber.Text = phone;

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            dgvpeople.Rows.Clear();
            string id = arrWinner[i].ID;
            string name = arrWinner[i].Name;
            string gander = arrWinner[i].Gender;
            string email = arrWinner[i].Email;
            dgvpeople.Rows.Add(id, name, gander, email);



        }
    }
}
