namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig051 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        EmployeeCode = c.String(maxLength: 10),
                        FullName = c.String(maxLength: 150),
                        NickName = c.String(maxLength: 150),
                        FathersName = c.String(maxLength: 150),
                        MothersName = c.String(maxLength: 150),
                        DesignationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Designations", t => t.DesignationId, cascadeDelete: true)
                .Index(t => t.DesignationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DesignationId", "dbo.Designations");
            DropIndex("dbo.Employees", new[] { "DesignationId" });
            DropTable("dbo.Employees");
        }
    }
}
