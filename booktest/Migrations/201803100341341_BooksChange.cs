namespace booktest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BooksChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Borrows", "Person_ID", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Remarks", "People_ID", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Remarks", "Book_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Borrows", "BookID");
            CreateIndex("dbo.Borrows", "Person_ID");
            CreateIndex("dbo.Remarks", "People_ID");
            CreateIndex("dbo.Remarks", "Book_ID");
            AddForeignKey("dbo.Borrows", "Person_ID", "dbo.People", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Remarks", "People_ID", "dbo.People", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Borrows", "BookID", "dbo.Books", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Remarks", "Book_ID", "dbo.Books", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Remarks", "Book_ID", "dbo.Books");
            DropForeignKey("dbo.Borrows", "BookID", "dbo.Books");
            DropForeignKey("dbo.Remarks", "People_ID", "dbo.People");
            DropForeignKey("dbo.Borrows", "Person_ID", "dbo.People");
            DropIndex("dbo.Remarks", new[] { "Book_ID" });
            DropIndex("dbo.Remarks", new[] { "People_ID" });
            DropIndex("dbo.Borrows", new[] { "Person_ID" });
            DropIndex("dbo.Borrows", new[] { "BookID" });
            DropColumn("dbo.Remarks", "Book_ID");
            DropColumn("dbo.Remarks", "People_ID");
            DropColumn("dbo.Borrows", "Person_ID");
        }
    }
}
