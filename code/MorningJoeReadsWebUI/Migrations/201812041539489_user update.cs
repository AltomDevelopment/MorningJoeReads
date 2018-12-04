namespace MorningJoeReadsWebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "PassWord", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "PassWord", c => c.String(nullable: false));
        }
    }
}
