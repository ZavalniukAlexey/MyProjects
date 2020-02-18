using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.tables
{
    class Routes
    {
       public string ID{ get; set; }
       public string StartingPoint{ get; set; }
       public string DestinationPoint{ get; set; }
       public string Length{ get; set; }
       public string Duration{ get; set; }
      
       public Routes(string id, string sp, string dp, string l, string d)
        {
            ID = id;
            StartingPoint = sp;
            DestinationPoint = dp;
            Length = l;
            Duration = d;
        }
}
}
