namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig071 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "BloodGroup", c => c.String(maxLength: 150));
            AddColumn("dbo.Employees", "Address", c => c.String(maxLength: 150));
            AddColumn("dbo.Employees", "PhoneNo", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "Email", c => c.String(maxLength: 100));
            AddColumn("dbo.Employees", "DeptId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "DeptId");
            AddForeignKey("dbo.Employees", "DeptId", "dbo.Depts", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DeptId", "dbo.Depts");
            DropIndex("dbo.Employees", new[] { "DeptId" });
            DropColumn("dbo.Employees", "DeptId");
            DropColumn("dbo.Employees", "Email");
            DropColumn("dbo.Employees", "PhoneNo");
            DropColumn("dbo.Employees", "Address");
            DropColumn("dbo.Employees", "BloodGroup");
        }
    }
}
