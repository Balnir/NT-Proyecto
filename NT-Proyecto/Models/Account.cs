using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NT_Proyecto.Models
{
    public class Account
    {
        public Account()
        {
            this.Ventas = new HashSet <Ventas>();
            this.MedioDePago = new HashSet<MedioDePago>();
        }
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NroTelefono { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual Domicilio Domicilio { get; set; }
        public virtual ICollection<MedioDePago> MedioDePago { get; set; }
        public virtual ICollection<Ventas> Ventas { get; set; }
    }
}