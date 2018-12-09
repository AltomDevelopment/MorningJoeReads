namespace MorningJoeReadsWebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
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
                        Users_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .Index(t => t.Users_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        EmailAddress = c.String(nullable: false),
                        PassWord = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Searches", "Users_Id", "dbo.Users");
            DropIndex("dbo.Searches", new[] { "Users_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Searches");
        }
    }
}
