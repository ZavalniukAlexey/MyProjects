using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.tables
{
    class Users
    {
        public string ID { get; set; }
        public string PhoneNumber{ get; set; }
        public string Name{ get; set; }
        public string Surname{ get; set; }
        public string Password { get; set; }
        public Users(string id, string pn, string n, string sn, string pw)
        {
            ID = id;
            PhoneNumber = pn;
            Name = n;
            Surname = sn;
            Password = pw;
        }
}
}
