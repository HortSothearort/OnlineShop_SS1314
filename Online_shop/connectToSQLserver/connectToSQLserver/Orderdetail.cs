using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connectToSQLserver
{
    class Orderdetail
    {
        public Orderdetail(int pID, int qty, double price)
        {
            this.pID = pID;
            this.qty = qty;
            this.price = price;
        }

        public int pID { get; set; }
        public int qty{ get; set; }
        public double price{ get; set; }


    }
}
