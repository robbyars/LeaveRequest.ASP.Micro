namespace LeaveRequest.ASP.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingModelMaster : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        CreatedBy = c.Int(nullable: false),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeletedBy = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        CreatedBy = c.Int(nullable: false),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeletedBy = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        Companies_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Companies_Id)
                .Index(t => t.Companies_Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Phone = c.Int(nullable: false),
                        JoinDate = c.DateTimeOffset(nullable: false, precision: 7),
                        JobTitle = c.String(),
                        Status = c.String(),
                        TotalChilds = c.Int(nullable: false),
                        ThisYear = c.Int(nullable: false),
                        LastYear = c.Int(nullable: false),
                        Password = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        CreatedBy = c.Int(nullable: false),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeletedBy = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        Departments_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Departments_Id)
                .Index(t => t.Departments_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Departments_Id", "dbo.Departments");
            DropForeignKey("dbo.Departments", "Companies_Id", "dbo.Companies");
            DropIndex("dbo.Employees", new[] { "Departments_Id" });
            DropIndex("dbo.Departments", new[] { "Companies_Id" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
            DropTable("dbo.Companies");
        }
    }
}
