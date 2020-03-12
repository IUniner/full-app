namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false),
                        Email = c.String(),
                        HasSpecialPermissions = c.Boolean(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CompanyEmployees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EmployeeId, t.CompanyId })
                .ForeignKey("dbo.Companies", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.CompanyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CompanyEmployees", "CompanyId", "dbo.Employees");
            DropForeignKey("dbo.CompanyEmployees", "EmployeeId", "dbo.Companies");
            DropForeignKey("dbo.UserProfiles", "Id", "dbo.Users");
            DropIndex("dbo.CompanyEmployees", new[] { "CompanyId" });
            DropIndex("dbo.CompanyEmployees", new[] { "EmployeeId" });
            DropIndex("dbo.UserProfiles", new[] { "Id" });
            DropTable("dbo.CompanyEmployees");
            DropTable("dbo.Employees");
            DropTable("dbo.Companies");
            DropTable("dbo.UserProfiles");
            DropTable("dbo.Users");
        }
    }
}
