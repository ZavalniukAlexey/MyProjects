using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Kursach.tables;
using System.Data.Common;
using System.Windows.Forms;
namespace Kursach.repos
{
    class ReposRoutes
    {
        public Connection connection;
        public ReposRoutes(Connection con)
        {
            connection = con;
        }
    }
}
