namespace MundoMascotaRosario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correccionmenu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menu", "PadreId", c => c.Int(nullable: false));
            DropColumn("dbo.Menu", "FatherId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Menu", "FatherId", c => c.Int(nullable: false));
            DropColumn("dbo.Menu", "PadreId");
        }
    }
}
