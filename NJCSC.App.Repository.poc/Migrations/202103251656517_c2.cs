namespace NJCSC.App.Repository.poc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class c2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Addresses", "ApplicationId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Addresses", "ApplicationId", c => c.Int(nullable: false));
        }
    }
}
