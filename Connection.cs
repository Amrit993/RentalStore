using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalStore
{
    public class Connection
    {
        private static string DataSource = @"SYSTEM";
        private static string Database   = "RentingStore";

        // Establishing Connection
        public static string GetConnection()
        {
            return @"Data Source="+ DataSource +"; Initial Catalog="+ Database +"; Integrated Security=True";
        }

        public string GetConn()
        {
            return GetConnection();
        }
    }
}
