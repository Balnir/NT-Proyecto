using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NT_Proyecto.Models
{
    public class VentaProducto
    {
        public VentaProducto()
        {
            this.Ventas = new HashSet<Ventas>();
        }

        public virtual ICollection<Ventas> Ventas { get; set; }
        public int Cantidad { get; set; }

        //public Libros()
        //{
        //    this.Autores = new HashSet<Autores>();
        //    this.Genero = new HashSet<Genero>();
        //}

    }
}