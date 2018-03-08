namespace booktest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Author = c.String(),
                        Publisher = c.String(),
                        Summary = c.String(),
                        Language = c.String(),
                        Situation = c.Boolean(nullable: false),
                        Person_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.People", t => t.Person_ID)
                .Index(t => t.Person_ID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                        Name = c.String(),
                        Gender = c.Boolean(nullable: false),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Administrator = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Person_ID", "dbo.People");
            DropIndex("dbo.Books", new[] { "Person_ID" });
            DropTable("dbo.People");
            DropTable("dbo.Books");
        }
    }
}
