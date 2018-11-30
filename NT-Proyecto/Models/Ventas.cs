using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;


namespace NT_Proyecto.Models
{
    public class Ventas
    {

        [Key]
        [Required]
        public int ID { get; set; }
        public Account account { get; set; }
        public MedioDePago medioDePago { get; set; }
        public virtual ICollection<VentaProducto> ventaProductos { get; set; }

    }
}