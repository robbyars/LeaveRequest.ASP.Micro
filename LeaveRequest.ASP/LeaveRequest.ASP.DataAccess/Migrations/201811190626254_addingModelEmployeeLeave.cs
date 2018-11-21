namespace LeaveRequest.ASP.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingModelEmployeeLeave : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeLeaves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTimeOffset(nullable: false, precision: 7),
                        EndDate = c.DateTimeOffset(nullable: false, precision: 7),
                        LeaveDays = c.Int(nullable: false),
                        Backup = c.String(),
                        Note = c.String(),
                        ApprovalStatus = c.String(),
                        ThisYearBefore = c.Int(nullable: false),
                        LastYearBefore = c.Int(nullable: false),
                        ThisYearAfter = c.Int(nullable: false),
                        LastYearAfter = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        CreatedBy = c.Int(nullable: false),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdatedBy = c.Int(nullable: false),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeletedBy = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        Employees_Id = c.Int(),
                        LeaveTypes_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employees_Id)
                .ForeignKey("dbo.LeaveTypes", t => t.LeaveTypes_Id)
                .Index(t => t.Employees_Id)
                .Index(t => t.LeaveTypes_Id);
            
            CreateTable(
                "dbo.LeaveTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TotalDays = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        CreatedBy = c.Int(nullable: false),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdatedBy = c.Int(nullable: false),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeletedBy = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeLeaves", "LeaveTypes_Id", "dbo.LeaveTypes");
            DropForeignKey("dbo.EmployeeLeaves", "Employees_Id", "dbo.Employees");
            DropIndex("dbo.EmployeeLeaves", new[] { "LeaveTypes_Id" });
            DropIndex("dbo.EmployeeLeaves", new[] { "Employees_Id" });
            DropTable("dbo.LeaveTypes");
            DropTable("dbo.EmployeeLeaves");
        }
    }
}
