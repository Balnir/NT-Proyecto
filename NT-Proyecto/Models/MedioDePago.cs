using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NT_Proyecto.Models
{
    public class MedioDePago
    {
        public string MDP { get; set; }
    }

    public class MedioDePagoDBContext : DbContext
    {
        public DbSet<MedioDePago> MediosDePago { get; set; }
    }
}