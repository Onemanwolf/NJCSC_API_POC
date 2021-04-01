namespace NJCSC.App.Repository.poc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class c1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmpApplications", "Address_ApplicationId", "dbo.Addresses");
            RenameColumn(table: "dbo.EmpApplications", name: "Address_ApplicationId", newName: "Address_AddressId");
            RenameIndex(table: "dbo.EmpApplications", name: "IX_Address_ApplicationId", newName: "IX_Address_AddressId");
            DropPrimaryKey("dbo.Addresses");
            AlterColumn("dbo.Addresses", "ApplicationId", c => c.Int(nullable: false));
            AlterColumn("dbo.Addresses", "AddressId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Addresses", "AddressId");
            AddForeignKey("dbo.EmpApplications", "Address_AddressId", "dbo.Addresses", "AddressId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmpApplications", "Address_AddressId", "dbo.Addresses");
            DropPrimaryKey("dbo.Addresses");
            AlterColumn("dbo.Addresses", "AddressId", c => c.Int(nullable: false));
            AlterColumn("dbo.Addresses", "ApplicationId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Addresses", "ApplicationId");
            RenameIndex(table: "dbo.EmpApplications", name: "IX_Address_AddressId", newName: "IX_Address_ApplicationId");
            RenameColumn(table: "dbo.EmpApplications", name: "Address_AddressId", newName: "Address_ApplicationId");
            AddForeignKey("dbo.EmpApplications", "Address_ApplicationId", "dbo.Addresses", "ApplicationId");
        }
    }
}
