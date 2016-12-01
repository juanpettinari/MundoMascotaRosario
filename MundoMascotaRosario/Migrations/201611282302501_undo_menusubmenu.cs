namespace MundoMascotaRosario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class undo_menusubmenu : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SubMenu", "PermisoId", "dbo.Permiso");
            DropForeignKey("dbo.Menu", "PaginaId", "dbo.Pagina");
            DropIndex("dbo.Menu", new[] { "PaginaId" });
            DropIndex("dbo.SubMenu", new[] { "PermisoId" });
            AddColumn("dbo.Pagina", "TextoMenu", c => c.String());
            AddColumn("dbo.Permiso", "TextoSubMenu", c => c.String());
            AddColumn("dbo.Permiso", "Url", c => c.String());
            DropTable("dbo.Menu");
            DropTable("dbo.SubMenu");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SubMenu",
                c => new
                    {
                        PermisoId = c.Int(nullable: false),
                        Nombre = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.PermisoId);
            
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        PaginaId = c.Int(nullable: false),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.PaginaId);
            
            DropColumn("dbo.Permiso", "Url");
            DropColumn("dbo.Permiso", "TextoSubMenu");
            DropColumn("dbo.Pagina", "TextoMenu");
            CreateIndex("dbo.SubMenu", "PermisoId");
            CreateIndex("dbo.Menu", "PaginaId");
            AddForeignKey("dbo.Menu", "PaginaId", "dbo.Pagina", "PaginaId");
            AddForeignKey("dbo.SubMenu", "PermisoId", "dbo.Permiso", "PermisoId");
        }
    }
}
