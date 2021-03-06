﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MundoMascotaRosario.Models;

namespace MundoMascotaRosario.DAL
{
    public class MMRContext : DbContext
    {
        public MMRContext() : base("MMRContext")
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<LineaDeProducto> LineasDeProducto { get; set; }
        public DbSet<OrdenDeCompra> OrdenesDeCompra { get; set; }

        public DbSet<Tarjeta> Tarjetas { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Provincia> Provincias { get; set; }

        public DbSet<RolMenu> RolesMenus { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Pagina> Paginas { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Perfil> Perfiles { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //SI EN ALGUN MOMENTO TIRA ERROR RECORDAR AGREGAR REMOVE<OneToManyCascadeDelete>
        }
    }
}