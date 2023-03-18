using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connectToSQLserver
{
    internal class student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public student(string id, string name)
        {

        }

        public student(string id,string name,string gener,string phone,string email)
        {
            ID = id;
            Name = name;
            Gender = gener;
            Phone = phone;
            Email = email;
        }


    }
}
