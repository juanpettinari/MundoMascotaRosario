namespace MundoMascotaRosario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullableint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Menu", "PadreId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Menu", "PadreId", c => c.Int(nullable: false));
        }
    }
}
