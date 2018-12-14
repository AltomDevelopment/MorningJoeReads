namespace MorningJoeReadsWebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rollbackdb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Searches", "ButtonList_ID", "dbo.SearchLists");
            DropForeignKey("dbo.SearchLists", "Users_Id", "dbo.Users");
            DropIndex("dbo.Searches", new[] { "ButtonList_ID" });
            DropIndex("dbo.SearchLists", new[] { "Users_Id" });
            DropColumn("dbo.Searches", "ButtonList_ID");
            DropTable("dbo.SearchLists");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SearchLists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Users_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Searches", "ButtonList_ID", c => c.Int());
            CreateIndex("dbo.SearchLists", "Users_Id");
            CreateIndex("dbo.Searches", "ButtonList_ID");
            AddForeignKey("dbo.SearchLists", "Users_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Searches", "ButtonList_ID", "dbo.SearchLists", "ID");
        }
    }
}
