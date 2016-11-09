namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hoteledited : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.HotelModels", newName: "Hotels");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Hotels", newName: "HotelModels");
        }
    }
}
