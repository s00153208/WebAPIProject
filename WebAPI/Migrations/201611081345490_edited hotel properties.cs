namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editedhotelproperties : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Hotels", "Name", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Hotels", "Address", c => c.String(nullable: false, maxLength: 120));
            AlterColumn("dbo.Hotels", "City", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Hotels", "County", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Hotels", "Phone", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Hotels", "Phone", c => c.String());
            AlterColumn("dbo.Hotels", "County", c => c.String());
            AlterColumn("dbo.Hotels", "City", c => c.String());
            AlterColumn("dbo.Hotels", "Address", c => c.String());
            AlterColumn("dbo.Hotels", "Name", c => c.String());
        }
    }
}
