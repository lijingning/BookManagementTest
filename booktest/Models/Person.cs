using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace booktest.Models
{
    public class Person
    {
        public string ID { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public bool Gender { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public bool Administrator { get; set; }

        public List<Book> Books { get; set; }

        public List<Remark> Remarks { get; set; }

        public List<Borrow> Borrows { get; set; }
    }

}