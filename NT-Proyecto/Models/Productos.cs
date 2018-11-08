using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NT_Proyecto.Models
{
    public class Productos
    {
        public int ID { get; set; }
        public int Cantidad { get; set; }
    }
    public class ProductosDBContext : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
    }

}