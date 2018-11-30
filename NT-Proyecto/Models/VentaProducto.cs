using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;


namespace NT_Proyecto.Models
{
    public class VentaProducto
    {
        public VentaProducto()
        {
            this.ventas = new HashSet<Ventas>();
        }
        [Key]
        [Required]
        public int VentaProductoID { get; set; }
        public virtual ICollection<Ventas> ventas { get; set; }
        public int cantidad { get; set; }

        //public Libros()
        //{
        //    this.Autores = new HashSet<Autores>();
        //    this.Genero = new HashSet<Genero>();
        //}

    }
}