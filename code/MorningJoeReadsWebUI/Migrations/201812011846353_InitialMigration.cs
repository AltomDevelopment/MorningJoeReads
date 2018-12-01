namespace MorningJoeReadsWebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Searches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SearchDescription = c.String(),
                        SearchName = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        TimesViewed = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        EmailAddress = c.String(nullable: false),
                        PassWord = c.String(nullable: false),
                        Searches_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Searches", t => t.Searches_Id)
                .Index(t => t.Searches_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Searches_Id", "dbo.Searches");
            DropIndex("dbo.Users", new[] { "Searches_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Searches");
        }
    }
}
