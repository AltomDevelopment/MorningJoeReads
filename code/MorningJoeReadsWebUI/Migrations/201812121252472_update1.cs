namespace MorningJoeReadsWebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "FirstName", c => c.String());
            AlterColumn("dbo.Users", "LastName", c => c.String());
            AlterColumn("dbo.Users", "EmailAddress", c => c.String());
            AlterColumn("dbo.Users", "PassWord", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "PassWord", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Users", "EmailAddress", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
