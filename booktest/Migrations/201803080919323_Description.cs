namespace booktest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Description : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Description", c => c.String());
            DropColumn("dbo.Books", "Publisher");
            DropColumn("dbo.Books", "Summary");
            DropColumn("dbo.Books", "Language");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Language", c => c.String());
            AddColumn("dbo.Books", "Summary", c => c.String());
            AddColumn("dbo.Books", "Publisher", c => c.String());
            DropColumn("dbo.Books", "Description");
        }
    }
}
