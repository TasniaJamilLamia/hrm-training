namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig04 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        SectionName = c.String(),
                        DeptId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Depts", t => t.DeptId, cascadeDelete: true)
                .Index(t => t.DeptId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sections", "DeptId", "dbo.Depts");
            DropIndex("dbo.Sections", new[] { "DeptId" });
            DropTable("dbo.Sections");
        }
    }
}
