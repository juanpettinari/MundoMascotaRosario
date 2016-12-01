namespace MundoMascotaRosario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class menu40 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Menu", "TextoMenu", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Menu", "TextoMenu", c => c.String());
        }
    }
}
