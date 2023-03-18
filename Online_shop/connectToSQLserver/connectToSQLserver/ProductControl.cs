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
    public partial class ProductControl : UserControl
    {
       

        public ProductControl(int id, string pname, Image im)
        {
            iD = id;
            Pname = pname;
        }

        public ProductControl(int ID,string pname,int instock, string price,Image Photo)
        {
            InitializeComponent();
            iD = ID;
            Pname = pname;
            Instock = instock;
            Price = price;
            photo = Photo;

        }
        public int iD { get; set; }
        public string Pname
        {
            get => txtdes.Text;
            set => txtdes.Text = value;
        }
        public int Instock { get; private set; }
        public int Intstock
        {
            get => int.Parse(lblinstock.Text);
            set => lblinstock.Text = value+"";
        }
        public string Price
        {
            get => txtprice.Text;
            set => txtprice.Text = value;
        }
        public Image photo
        {
            get => PicPhoto.Image;
            set => PicPhoto.Image = value;

        }
        public int Qty { get; set; }








    }
}


