using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;


namespace NT_Proyecto.Models
{
    public class Productos
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public decimal PrecioUnitario { get; set; }
    }

}