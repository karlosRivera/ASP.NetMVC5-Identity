namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addfieldstoAspNetUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "LastLoginDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "LastPwdChangeDateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.AspNetUsers", "EmailID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "EmailID", c => c.String());
            DropColumn("dbo.AspNetUsers", "LastPwdChangeDateTime");
            DropColumn("dbo.AspNetUsers", "LastLoginDateTime");
        }
    }
}
