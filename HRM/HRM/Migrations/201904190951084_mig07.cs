namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig07 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sections", "SectionCode", c => c.String(maxLength: 10));
            AlterColumn("dbo.Sections", "SectionName", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sections", "SectionName", c => c.String());
            DropColumn("dbo.Sections", "SectionCode");
        }
    }
}
