namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig06 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ShortName = c.String(),
                        DesignationName = c.String(),
                        Division_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Divisions", t => t.Division_id)
                .Index(t => t.Division_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Designations", "Division_id", "dbo.Divisions");
            DropIndex("dbo.Designations", new[] { "Division_id" });
            DropTable("dbo.Designations");
        }
    }
}
