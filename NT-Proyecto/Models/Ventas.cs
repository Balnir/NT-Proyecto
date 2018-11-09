using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NT_Proyecto.Models
{
    public class Ventas
    {

        public int ID { get; set; }
        public Account Account { get; set; }
        public MedioDePago MedioDePago { get; set; }
        public virtual ICollection<VentaProducto> VentaProductos { get; set; }

    }
}