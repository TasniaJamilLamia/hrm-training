namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig02 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Divisions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        DivisionCode = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Divisions");
        }
    }
}
