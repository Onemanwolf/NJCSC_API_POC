namespace NJCSC.App.Repository.poc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class c4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmpApplications", "Address_AddressId", "dbo.Addresses");
            DropIndex("dbo.EmpApplications", new[] { "Address_AddressId" });
            AlterColumn("dbo.EmpApplications", "Address_AddressId", c => c.Int(nullable: false));
            CreateIndex("dbo.EmpApplications", "Address_AddressId");
            AddForeignKey("dbo.EmpApplications", "Address_AddressId", "dbo.Addresses", "AddressId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmpApplications", "Address_AddressId", "dbo.Addresses");
            DropIndex("dbo.EmpApplications", new[] { "Address_AddressId" });
            AlterColumn("dbo.EmpApplications", "Address_AddressId", c => c.Int());
            CreateIndex("dbo.EmpApplications", "Address_AddressId");
            AddForeignKey("dbo.EmpApplications", "Address_AddressId", "dbo.Addresses", "AddressId");
        }
    }
}
