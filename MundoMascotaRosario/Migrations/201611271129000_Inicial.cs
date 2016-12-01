namespace MundoMascotaRosario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accion",
                c => new
                    {
                        AccionId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false),
                        PaginaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AccionId)
                .ForeignKey("dbo.Pagina", t => t.PaginaId, cascadeDelete: true)
                .Index(t => t.PaginaId);
            
            CreateTable(
                "dbo.Pagina",
                c => new
                    {
                        PaginaId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PaginaId);
            
            CreateTable(
                "dbo.Permiso",
                c => new
                    {
                        RolId = c.Int(nullable: false),
                        AccionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RolId, t.AccionId })
                .ForeignKey("dbo.Accion", t => t.AccionId, cascadeDelete: true)
                .ForeignKey("dbo.Rol", t => t.RolId, cascadeDelete: true)
                .Index(t => t.RolId)
                .Index(t => t.AccionId);
            
            CreateTable(
                "dbo.Rol",
                c => new
                    {
                        RolId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RolId);
            
            CreateTable(
                "dbo.Ciudad",
                c => new
                    {
                        CiudadId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        ProvinciaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CiudadId)
                .ForeignKey("dbo.Provincia", t => t.ProvinciaId, cascadeDelete: true)
                .Index(t => t.ProvinciaId);
            
            CreateTable(
                "dbo.Direccion",
                c => new
                    {
                        DireccionId = c.Int(nullable: false, identity: true),
                        CiudadId = c.Int(nullable: false),
                        Calle = c.String(),
                        Nro = c.Int(nullable: false),
                        CodigoPostal = c.String(),
                    })
                .PrimaryKey(t => t.DireccionId)
                .ForeignKey("dbo.Ciudad", t => t.CiudadId, cascadeDelete: true)
                .Index(t => t.CiudadId);
            
            CreateTable(
                "dbo.OrdenDeCompra",
                c => new
                    {
                        OrdenId = c.Int(nullable: false, identity: true),
                        UsuarioId = c.Int(nullable: false),
                        FechaCompra = c.DateTime(nullable: false),
                        DireccionDeEnvioId = c.Int(nullable: false),
                        FormaDePago = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        TotalDecimal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Direccion_DireccionId = c.Int(),
                        Tarjeta_TarjetaId = c.Int(),
                    })
                .PrimaryKey(t => t.OrdenId)
                .ForeignKey("dbo.Direccion", t => t.Direccion_DireccionId)
                .ForeignKey("dbo.Tarjeta", t => t.Tarjeta_TarjetaId)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId)
                .Index(t => t.Direccion_DireccionId)
                .Index(t => t.Tarjeta_TarjetaId);
            
            CreateTable(
                "dbo.LineaDeProducto",
                c => new
                    {
                        LineaDeProductoId = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        SubtotalDecimal = c.Decimal(precision: 18, scale: 2),
                        CarritoDeCompraId = c.Int(nullable: false),
                        OrdenDeCompra_OrdenId = c.Int(),
                    })
                .PrimaryKey(t => t.LineaDeProductoId)
                .ForeignKey("dbo.CarritoDeCompra", t => t.CarritoDeCompraId, cascadeDelete: true)
                .ForeignKey("dbo.Producto", t => t.ProductoId, cascadeDelete: true)
                .ForeignKey("dbo.OrdenDeCompra", t => t.OrdenDeCompra_OrdenId)
                .Index(t => t.ProductoId)
                .Index(t => t.CarritoDeCompraId)
                .Index(t => t.OrdenDeCompra_OrdenId);
            
            CreateTable(
                "dbo.CarritoDeCompra",
                c => new
                    {
                        CarritoDeCompraId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.CarritoDeCompraId);
            
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        ProductoId = c.Int(nullable: false, identity: true),
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
                        TarjetaId = c.Int(nullable: false, identity: true),
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
                        UsuarioId = c.Int(nullable: false, identity: true),
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
                        ProvinciaId = c.Int(nullable: false, identity: true),
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
            DropForeignKey("dbo.LineaDeProducto", "CarritoDeCompraId", "dbo.CarritoDeCompra");
            DropForeignKey("dbo.OrdenDeCompra", "Direccion_DireccionId", "dbo.Direccion");
            DropForeignKey("dbo.Direccion", "CiudadId", "dbo.Ciudad");
            DropForeignKey("dbo.Permiso", "RolId", "dbo.Rol");
            DropForeignKey("dbo.Permiso", "AccionId", "dbo.Accion");
            DropForeignKey("dbo.Accion", "PaginaId", "dbo.Pagina");
            DropIndex("dbo.LineaDeProducto", new[] { "OrdenDeCompra_OrdenId" });
            DropIndex("dbo.LineaDeProducto", new[] { "CarritoDeCompraId" });
            DropIndex("dbo.LineaDeProducto", new[] { "ProductoId" });
            DropIndex("dbo.OrdenDeCompra", new[] { "Tarjeta_TarjetaId" });
            DropIndex("dbo.OrdenDeCompra", new[] { "Direccion_DireccionId" });
            DropIndex("dbo.OrdenDeCompra", new[] { "UsuarioId" });
            DropIndex("dbo.Direccion", new[] { "CiudadId" });
            DropIndex("dbo.Ciudad", new[] { "ProvinciaId" });
            DropIndex("dbo.Permiso", new[] { "AccionId" });
            DropIndex("dbo.Permiso", new[] { "RolId" });
            DropIndex("dbo.Accion", new[] { "PaginaId" });
            DropTable("dbo.Provincia");
            DropTable("dbo.Usuario");
            DropTable("dbo.Tarjeta");
            DropTable("dbo.Producto");
            DropTable("dbo.CarritoDeCompra");
            DropTable("dbo.LineaDeProducto");
            DropTable("dbo.OrdenDeCompra");
            DropTable("dbo.Direccion");
            DropTable("dbo.Ciudad");
            DropTable("dbo.Rol");
            DropTable("dbo.Permiso");
            DropTable("dbo.Pagina");
            DropTable("dbo.Accion");
        }
    }
}
