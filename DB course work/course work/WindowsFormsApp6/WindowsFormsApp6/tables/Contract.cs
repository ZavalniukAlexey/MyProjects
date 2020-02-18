using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.tables
{
    class Contract
    {
        public string ID { get; set; }
        public string UserID { get; set; }
        public string StartingPoint { get; set; }
        public string DestinationPoint { get; set; }
        public string Weight { get; set; }
        public string IsMade { get; set; }
        public string DateOfStart { get; set; }
        public string DateOfFinish { get; set; }
        public string Cost { get; set; }
        public string RouteID { get; set; }
        public string ShipID { get; set; }

        public Contract(string id, string uid, string SP, string DP, string W, string IM, string DOS, string DOF, string C, string rid, string sid)
        {
            ID = id;
            UserID = uid;
            StartingPoint = SP;
            DestinationPoint = DP;
            Weight = W;
            IsMade = IM;
            DateOfStart = DOS;
            DateOfFinish = DOF;
            Cost = C;
            RouteID = rid;
            ShipID = sid;
        }
    }
}
