namespace NJCSC.App.Repository.poc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class c10 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmpApplications", "Address_AddressId", "dbo.Addresses");
            DropPrimaryKey("dbo.Addresses");
            AlterColumn("dbo.Addresses", "AddressId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Addresses", "AddressId");
            AddForeignKey("dbo.EmpApplications", "Address_AddressId", "dbo.Addresses", "AddressId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmpApplications", "Address_AddressId", "dbo.Addresses");
            DropPrimaryKey("dbo.Addresses");
            AlterColumn("dbo.Addresses", "AddressId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Addresses", "AddressId");
            AddForeignKey("dbo.EmpApplications", "Address_AddressId", "dbo.Addresses", "AddressId", cascadeDelete: true);
        }
    }
}
