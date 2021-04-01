namespace NJCSC.App.Repository.poc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class c11 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.EmpApplications");
            AlterColumn("dbo.EmpApplications", "ApplicationId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.EmpApplications", "ApplicationId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.EmpApplications");
            AlterColumn("dbo.EmpApplications", "ApplicationId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.EmpApplications", "ApplicationId");
        }
    }
}
