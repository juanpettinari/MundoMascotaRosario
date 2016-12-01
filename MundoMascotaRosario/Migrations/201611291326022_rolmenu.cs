namespace MundoMascotaRosario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rolmenu : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Menu", "RolId", "dbo.Rol");
            DropIndex("dbo.Menu", new[] { "RolId" });
            CreateTable(
                "dbo.RolMenu",
                c => new
                    {
                        RolId = c.Int(nullable: false),
                        MenuId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RolId, t.MenuId })
                .ForeignKey("dbo.Menu", t => t.MenuId, cascadeDelete: true)
                .ForeignKey("dbo.Rol", t => t.RolId, cascadeDelete: true)
                .Index(t => t.RolId)
                .Index(t => t.MenuId);
            
            DropColumn("dbo.Menu", "RolId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Menu", "RolId", c => c.Int(nullable: false));
            DropForeignKey("dbo.RolMenu", "RolId", "dbo.Rol");
            DropForeignKey("dbo.RolMenu", "MenuId", "dbo.Menu");
            DropIndex("dbo.RolMenu", new[] { "MenuId" });
            DropIndex("dbo.RolMenu", new[] { "RolId" });
            DropTable("dbo.RolMenu");
            CreateIndex("dbo.Menu", "RolId");
            AddForeignKey("dbo.Menu", "RolId", "dbo.Rol", "RolId", cascadeDelete: true);
        }
    }
}
