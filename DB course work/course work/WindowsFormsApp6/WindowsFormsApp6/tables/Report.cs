using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.tables
{
    class Report
    {
        public string ID { get; set; }
        public string Location { get; set; }
        public string DateOfArrival { get; set; }
        public string ReportID { get; set; }

        public Report(string id, string l, string doa, string rid)
        {
            ID = id;
            Location = l;
            DateOfArrival = doa;
            ReportID = rid;
        }
    }
}
