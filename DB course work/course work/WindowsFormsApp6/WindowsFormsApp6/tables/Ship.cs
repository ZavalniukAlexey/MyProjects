using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.tables
{
    class Ship
    {
        public string ID { get; set; }
        public string Name{ get; set; }
        public string CarryingWeight{ get; set; }
        public string Location{ get; set; }
        public Ship(string id, string n, string cw, string l)
        {
            ID = id;
            Name = n;
            CarryingWeight = cw;
            Location = l;
        }
}
}
