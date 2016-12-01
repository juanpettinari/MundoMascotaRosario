namespace MundoMascotaRosario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class menu_submenu : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Accion", "PaginaId", "dbo.Pagina");
            DropForeignKey("dbo.Permiso", "AccionId", "dbo.Accion");
            DropForeignKey("dbo.Permiso", "RolId", "dbo.Rol");
            DropIndex("dbo.Accion", new[] { "PaginaId" });
            DropIndex("dbo.Permiso", new[] { "RolId" });
            DropIndex("dbo.Permiso", new[] { "AccionId" });
            DropPrimaryKey("dbo.Permiso");
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        PaginaId = c.Int(nullable: false),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.PaginaId)
                .ForeignKey("dbo.Pagina", t => t.PaginaId)
                .Index(t => t.PaginaId);
            
            CreateTable(
                "dbo.Perfil",
                c => new
                    {
                        RolId = c.Int(nullable: false),
                        PermisoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RolId, t.PermisoId })
                .ForeignKey("dbo.Permiso", t => t.PermisoId, cascadeDelete: true)
                .ForeignKey("dbo.Rol", t => t.RolId, cascadeDelete: true)
                .Index(t => t.RolId)
                .Index(t => t.PermisoId);
            
            CreateTable(
                "dbo.SubMenu",
                c => new
                    {
                        PermisoId = c.Int(nullable: false),
                        Nombre = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.PermisoId)
                .ForeignKey("dbo.Permiso", t => t.PermisoId)
                .Index(t => t.PermisoId);
            
            AddColumn("dbo.Permiso", "PermisoId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Permiso", "Descripcion", c => c.String(nullable: false));
            AddColumn("dbo.Permiso", "PaginaId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Permiso", "PermisoId");
            CreateIndex("dbo.Permiso", "PaginaId");
            AddForeignKey("dbo.Permiso", "PaginaId", "dbo.Pagina", "PaginaId", cascadeDelete: true);
            DropColumn("dbo.Permiso", "RolId");
            DropColumn("dbo.Permiso", "AccionId");
            DropTable("dbo.Accion");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Accion",
                c => new
                    {
                        AccionId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false),
                        PaginaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AccionId);
            
            AddColumn("dbo.Permiso", "AccionId", c => c.Int(nullable: false));
            AddColumn("dbo.Permiso", "RolId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Menu", "PaginaId", "dbo.Pagina");
            DropForeignKey("dbo.SubMenu", "PermisoId", "dbo.Permiso");
            DropForeignKey("dbo.Perfil", "RolId", "dbo.Rol");
            DropForeignKey("dbo.Perfil", "PermisoId", "dbo.Permiso");
            DropForeignKey("dbo.Permiso", "PaginaId", "dbo.Pagina");
            DropIndex("dbo.SubMenu", new[] { "PermisoId" });
            DropIndex("dbo.Perfil", new[] { "PermisoId" });
            DropIndex("dbo.Perfil", new[] { "RolId" });
            DropIndex("dbo.Permiso", new[] { "PaginaId" });
            DropIndex("dbo.Menu", new[] { "PaginaId" });
            DropPrimaryKey("dbo.Permiso");
            DropColumn("dbo.Permiso", "PaginaId");
            DropColumn("dbo.Permiso", "Descripcion");
            DropColumn("dbo.Permiso", "PermisoId");
            DropTable("dbo.SubMenu");
            DropTable("dbo.Perfil");
            DropTable("dbo.Menu");
            AddPrimaryKey("dbo.Permiso", new[] { "RolId", "AccionId" });
            CreateIndex("dbo.Permiso", "AccionId");
            CreateIndex("dbo.Permiso", "RolId");
            CreateIndex("dbo.Accion", "PaginaId");
            AddForeignKey("dbo.Permiso", "RolId", "dbo.Rol", "RolId", cascadeDelete: true);
            AddForeignKey("dbo.Permiso", "AccionId", "dbo.Accion", "AccionId", cascadeDelete: true);
            AddForeignKey("dbo.Accion", "PaginaId", "dbo.Pagina", "PaginaId", cascadeDelete: true);
        }
    }
}
