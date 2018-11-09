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
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public decimal PrecioUnitario { get; set; }
    }

}