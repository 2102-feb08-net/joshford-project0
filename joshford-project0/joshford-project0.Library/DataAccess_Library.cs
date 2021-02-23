using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace joshford_project0.Library
{
    public class DataAccess_Library
    {
        /// <summary>
        /// Creates a context to be passed to classes for the database connection
        /// </summary>
        /// <returns></returns>
        public static joshfordproject0Context OpenDatabaseConnection()
        {
            string connectionString = File.ReadAllText("~/Revature/joshford-project0/ConnectionString.txt");
            DbContextOptions<joshfordproject0Context> options = new DbContextOptionsBuilder<joshfordproject0Context>()
                .UseSqlServer(connectionString)
                .Options;
            var context = new joshfordproject0Context(options);

            return context;
        }
    }
}
