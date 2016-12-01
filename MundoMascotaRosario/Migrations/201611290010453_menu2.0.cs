namespace MundoMascotaRosario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class menu20 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        MenuId = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                        TextoMenu = c.String(),
                        FatherId = c.Int(nullable: false),
                        RolId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MenuId)
                .ForeignKey("dbo.Rol", t => t.RolId, cascadeDelete: true)
                .Index(t => t.RolId);
            
            DropColumn("dbo.Pagina", "TextoMenu");
            DropColumn("dbo.Permiso", "TextoSubMenu");
            DropColumn("dbo.Permiso", "Url");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Permiso", "Url", c => c.String());
            AddColumn("dbo.Permiso", "TextoSubMenu", c => c.String());
            AddColumn("dbo.Pagina", "TextoMenu", c => c.String());
            DropForeignKey("dbo.Menu", "RolId", "dbo.Rol");
            DropIndex("dbo.Menu", new[] { "RolId" });
            DropTable("dbo.Menu");
        }
    }
}
