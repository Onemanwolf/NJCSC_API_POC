namespace NJCSC.App.Repository.poc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        ApplicationId = c.Int(nullable: false, identity: true),
                        AddressId = c.Int(nullable: false),
                        Street = c.String(),
                        City = c.String(),
                        State = c.String(),
                        PostalCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ApplicationId);
            
            CreateTable(
                "dbo.EmpApplications",
                c => new
                    {
                        ApplicationId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        EmailAddress = c.String(),
                        PhoneNumber = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        Address_ApplicationId = c.Int(),
                    })
                .PrimaryKey(t => t.ApplicationId)
                .ForeignKey("dbo.Addresses", t => t.Address_ApplicationId)
                .Index(t => t.Address_ApplicationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmpApplications", "Address_ApplicationId", "dbo.Addresses");
            DropIndex("dbo.EmpApplications", new[] { "Address_ApplicationId" });
            DropTable("dbo.EmpApplications");
            DropTable("dbo.Addresses");
        }
    }
}
