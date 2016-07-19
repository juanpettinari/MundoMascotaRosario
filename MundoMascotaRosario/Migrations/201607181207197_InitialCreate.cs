namespace MundoMascotaRosario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ciudad",
                c => new
                    {
                        CiudadId = c.String(nullable: false, maxLength: 128),
                        Descripcion = c.String(),
                        ProvinciaId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CiudadId)
                .ForeignKey("dbo.Provincia", t => t.ProvinciaId)
                .Index(t => t.ProvinciaId);
            
            CreateTable(
                "dbo.Direccion",
                c => new
                    {
                        DireccionId = c.String(nullable: false, maxLength: 128),
                        CiudadId = c.String(maxLength: 128),
                        Calle = c.String(),
                        Nro = c.Int(nullable: false),
                        CodigoPostal = c.String(),
                    })
                .PrimaryKey(t => t.DireccionId)
                .ForeignKey("dbo.Ciudad", t => t.CiudadId)
                .Index(t => t.CiudadId);
            
            CreateTable(
                "dbo.OrdenDeCompra",
                c => new
                    {
                        OrdenId = c.String(nullable: false, maxLength: 128),
                        UsuarioId = c.String(maxLength: 128),
                        FechaCompra = c.DateTime(nullable: false),
                        DireccionDeEnvioId = c.String(),
                        FormaDePago = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        TotalDecimal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Direccion_DireccionId = c.String(maxLength: 128),
                        Tarjeta_TarjetaId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.OrdenId)
                .ForeignKey("dbo.Direccion", t => t.Direccion_DireccionId)
                .ForeignKey("dbo.Tarjeta", t => t.Tarjeta_TarjetaId)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId)
                .Index(t => t.UsuarioId)
                .Index(t => t.Direccion_DireccionId)
                .Index(t => t.Tarjeta_TarjetaId);
            
            CreateTable(
                "dbo.LineaDeProducto",
                c => new
                    {
                        LineaDeProductoId = c.String(nullable: false, maxLength: 128),
                        Cantidad = c.Int(nullable: false),
                        ProductoId = c.String(maxLength: 128),
                        OrdenDeCompra_OrdenId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.LineaDeProductoId)
                .ForeignKey("dbo.Producto", t => t.ProductoId)
                .ForeignKey("dbo.OrdenDeCompra", t => t.OrdenDeCompra_OrdenId)
                .Index(t => t.ProductoId)
                .Index(t => t.OrdenDeCompra_OrdenId);
            
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        ProductoId = c.String(nullable: false, maxLength: 128),
                        Animal = c.String(),
                        Descripcion = c.String(),
                        Marca = c.String(),
                        Stock = c.Int(nullable: false),
                        PrecioDecimal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Imagen = c.String(),
                    })
                .PrimaryKey(t => t.ProductoId);
            
            CreateTable(
                "dbo.Tarjeta",
                c => new
                    {
                        TarjetaId = c.String(nullable: false, maxLength: 128),
                        TipoDeTarjeta = c.Int(nullable: false),
                        NumeroTarjeta = c.String(),
                        MesExpiracion = c.Int(nullable: false),
                        AnoExpiracion = c.Int(nullable: false),
                        NombreTitular = c.String(),
                        DniTitular = c.String(),
                        CodigoSeguridad = c.String(),
                        Estado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TarjetaId);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioId = c.String(nullable: false, maxLength: 128),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Nombre = c.String(nullable: false),
                        Apellido = c.String(nullable: false),
                        Telefono = c.String(nullable: false),
                        TipoDeDocumento = c.Int(nullable: false),
                        NroDocumento = c.String(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Provincia",
                c => new
                    {
                        ProvinciaId = c.String(nullable: false, maxLength: 128),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.ProvinciaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ciudad", "ProvinciaId", "dbo.Provincia");
            DropForeignKey("dbo.OrdenDeCompra", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.OrdenDeCompra", "Tarjeta_TarjetaId", "dbo.Tarjeta");
            DropForeignKey("dbo.LineaDeProducto", "OrdenDeCompra_OrdenId", "dbo.OrdenDeCompra");
            DropForeignKey("dbo.LineaDeProducto", "ProductoId", "dbo.Producto");
            DropForeignKey("dbo.OrdenDeCompra", "Direccion_DireccionId", "dbo.Direccion");
            DropForeignKey("dbo.Direccion", "CiudadId", "dbo.Ciudad");
            DropIndex("dbo.LineaDeProducto", new[] { "OrdenDeCompra_OrdenId" });
            DropIndex("dbo.LineaDeProducto", new[] { "ProductoId" });
            DropIndex("dbo.OrdenDeCompra", new[] { "Tarjeta_TarjetaId" });
            DropIndex("dbo.OrdenDeCompra", new[] { "Direccion_DireccionId" });
            DropIndex("dbo.OrdenDeCompra", new[] { "UsuarioId" });
            DropIndex("dbo.Direccion", new[] { "CiudadId" });
            DropIndex("dbo.Ciudad", new[] { "ProvinciaId" });
            DropTable("dbo.Provincia");
            DropTable("dbo.Usuario");
            DropTable("dbo.Tarjeta");
            DropTable("dbo.Producto");
            DropTable("dbo.LineaDeProducto");
            DropTable("dbo.OrdenDeCompra");
            DropTable("dbo.Direccion");
            DropTable("dbo.Ciudad");
        }
    }
}
