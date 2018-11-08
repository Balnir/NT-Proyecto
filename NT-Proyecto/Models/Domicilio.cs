using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NT_Proyecto.Models
{
    public class Domicilio
        { 
            public string Provincia { get; set; }
            public string Barrio { get; set; }
        }
    public class DomicilioDBContext : DbContext
    {
        public DbSet<Domicilio> Domicilios { get; set; }
    }
}
