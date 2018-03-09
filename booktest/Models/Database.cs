using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace booktest.Models
{
    public class Database:DbContext
    {
        public Database():base(@"Name = Database")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasOptional(o => o.Person).WithMany(p => p.Books);
            modelBuilder.Entity<Book>().HasMany(o => o.Borrows).WithRequired( b=>b.Book);
            modelBuilder.Entity<Book>().HasMany(o => o.Remarks).WithRequired(b => b.Book);

            modelBuilder.Entity<Person>().HasMany(o => o.Remarks).WithRequired(r => r.People);
            modelBuilder.Entity<Person>().HasMany(o => o.Books);
            modelBuilder.Entity<Person>().HasMany(o => o.Borrows).WithRequired(r => r.Person);


            
        }

        public virtual DbSet<Book> Books { get; set; }

        public virtual DbSet<Person> Persons { get; set; }

        public virtual DbSet<Borrow> Borrow { get; set; }

        public virtual DbSet<Remark> Remarks { get; set; }


    }
}