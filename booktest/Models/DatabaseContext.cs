using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Text;

namespace booktest.Models
{
    public class DatabaseContext
    {
        private static Database database;

        private static readonly object locker = new object();

        public static Database GetInstance()
        {
            if(database == null )
            {
                lock(locker)
                {
                    if(database==null)
                    {
                        database = new Database();
                    }
                }
            }
            return database;
        }

        public static async Task<Database> GetInstanceAsync()
        {
            return await Task.Run(() => GetInstance());
        }
    }
}