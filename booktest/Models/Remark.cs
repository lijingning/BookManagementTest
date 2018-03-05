using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace booktest.Models
{
    public class Remark
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public string Date { get; set; }
        public List<Book> Books = new List<Book>();
        public List<Person> Persons = new List<Person>();
    }

    public class RemarkDBContext : BooksDBContext
    {
        public RemarkDBContext()
        {

        }
        public DbSet<Remark> Remarks { get; set; }
    }
}