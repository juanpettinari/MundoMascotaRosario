namespace MundoMascotaRosario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioEnLineaDeProductos : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.LineaDeProducto", "ProductoId", "dbo.Producto");
            DropIndex("dbo.LineaDeProducto", new[] { "ProductoId" });
            CreateTable(
                "dbo.CarritoDeCompra",
                c => new
                    {
                        CarritoDeCompraId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.CarritoDeCompraId);
            
            AddColumn("dbo.LineaDeProducto", "CarritoDeCompraId", c => c.String(maxLength: 128));
            AlterColumn("dbo.LineaDeProducto", "ProductoId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.LineaDeProducto", "ProductoId");
            CreateIndex("dbo.LineaDeProducto", "CarritoDeCompraId");
            AddForeignKey("dbo.LineaDeProducto", "CarritoDeCompraId", "dbo.CarritoDeCompra", "CarritoDeCompraId");
            AddForeignKey("dbo.LineaDeProducto", "ProductoId", "dbo.Producto", "ProductoId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LineaDeProducto", "ProductoId", "dbo.Producto");
            DropForeignKey("dbo.LineaDeProducto", "CarritoDeCompraId", "dbo.CarritoDeCompra");
            DropIndex("dbo.LineaDeProducto", new[] { "CarritoDeCompraId" });
            DropIndex("dbo.LineaDeProducto", new[] { "ProductoId" });
            AlterColumn("dbo.LineaDeProducto", "ProductoId", c => c.String(maxLength: 128));
            DropColumn("dbo.LineaDeProducto", "CarritoDeCompraId");
            DropTable("dbo.CarritoDeCompra");
            CreateIndex("dbo.LineaDeProducto", "ProductoId");
            AddForeignKey("dbo.LineaDeProducto", "ProductoId", "dbo.Producto", "ProductoId");
        }
    }
}
