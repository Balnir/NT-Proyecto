using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;

namespace NT_Proyecto.Models
{
    public class Account
    {
        public Account()
        {
            this.ventas = new HashSet<Ventas>();
            this.medioDePago = new HashSet<MedioDePago>();
        }
        [Key]
        [Required]
        public int ID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string nroTelefono { get; set; }
        [Required]
        public string email { get; set; } 
        [PasswordPropertyText]
        public string password { get; set; }
        public virtual Domicilio domicilio { get; set; }
        public virtual ICollection<MedioDePago> medioDePago { get; set; }
        public virtual ICollection<Ventas> ventas { get; set; }
    }
}