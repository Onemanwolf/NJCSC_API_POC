namespace NJCSC.App.Repository.poc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class c14 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmpApplications", "Address_AddressId", "dbo.Addresses");
            DropIndex("dbo.EmpApplications", new[] { "Address_AddressId" });
            DropColumn("dbo.EmpApplications", "Address_AddressId");
            DropTable("dbo.Addresses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false),
                        Street = c.String(),
                        City = c.String(),
                        State = c.String(),
                        PostalCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddressId);
            
            AddColumn("dbo.EmpApplications", "Address_AddressId", c => c.Int(nullable: false));
            CreateIndex("dbo.EmpApplications", "Address_AddressId");
            AddForeignKey("dbo.EmpApplications", "Address_AddressId", "dbo.Addresses", "AddressId", cascadeDelete: true);
        }
    }
}
