using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace booktest.Models
{
    public class Book
    {
        
        public int ID { get; set; }

        public string LookUp { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public bool Situation { get; set; }  //True 代表可借（未被借走），False代表不可借（已被借走）

        public Person Person { get; set; }

        public List<Remark> Remarks { get; set; }

        public List<Borrow> Borrows { get; set; }
    }
}