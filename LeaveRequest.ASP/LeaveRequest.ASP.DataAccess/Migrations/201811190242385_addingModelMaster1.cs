namespace LeaveRequest.ASP.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingModelMaster1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "ManagerId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "ManagerId");
        }
    }
}
