using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NT_Proyecto.Models
{
    public class Ventas
    {
        public Account Account { get; set; }
        public MedioDePago MedioDePago { get; set; }
        public virtual ICollection<Productos> Productos { get; set; }

        public class VentasDBContext : DbContext
        {
            public DbSet<Ventas> Ventas { get; set; }
        }
    }
}