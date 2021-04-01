namespace NJCSC.App.Repository.poc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class c15 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmpApplications", "DateOfBirth", c => c.DateTime());
            AlterColumn("dbo.EmpApplications", "CreatedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EmpApplications", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.EmpApplications", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
