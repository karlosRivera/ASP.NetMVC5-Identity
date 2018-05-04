namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsActiveColAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "IsActive", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "IsActive");
        }
    }
}
