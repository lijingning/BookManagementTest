namespace booktest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IDchange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "LookUp", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "LookUp");
        }
    }
}
