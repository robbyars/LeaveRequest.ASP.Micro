namespace LeaveRequest.ASP.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingModelEmployeeLeaves : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmployeeLeaves", "StartDate", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.EmployeeLeaves", "EndDate", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.EmployeeLeaves", "LeaveDays", c => c.Int());
            AlterColumn("dbo.EmployeeLeaves", "ThisYearBefore", c => c.Int());
            AlterColumn("dbo.EmployeeLeaves", "LastYearBefore", c => c.Int());
            AlterColumn("dbo.EmployeeLeaves", "ThisYearAfter", c => c.Int());
            AlterColumn("dbo.EmployeeLeaves", "LastYearAfter", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EmployeeLeaves", "LastYearAfter", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeLeaves", "ThisYearAfter", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeLeaves", "LastYearBefore", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeLeaves", "ThisYearBefore", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeLeaves", "LeaveDays", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeLeaves", "EndDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.EmployeeLeaves", "StartDate", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
    }
}
