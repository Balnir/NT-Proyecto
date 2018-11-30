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
        public string nombre { get; set; }
        public string marca { get; set; }
        public decimal precioUnitario { get; set; }
    }

}