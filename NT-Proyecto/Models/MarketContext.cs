using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NT_Proyecto.Models
{
    public class MarketContext : DbContext
    {
            public DbSet<Account> Accounts { get; set; }
            public DbSet<Domicilio> Domicilios { get; set; }
            public DbSet<MedioDePago> MedioDePagos { get; set; }
            public DbSet<Productos> Productos { get; set; }
            public DbSet<VentaProducto> VentaProductos { get; set; }
            public DbSet<Ventas> Ventas { get; set; }
    }
}