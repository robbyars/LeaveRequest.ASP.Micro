namespace LeaveRequest.ASP.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingModelMaster2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "UpdatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.Departments", "UpdatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "UpdatedBy", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "UpdatedBy");
            DropColumn("dbo.Departments", "UpdatedBy");
            DropColumn("dbo.Companies", "UpdatedBy");
        }
    }
}
