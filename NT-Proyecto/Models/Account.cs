using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace NT_Proyecto.Models
{
    public class Account
    {
        public Account()
        {
            this.Ventas = new HashSet<Ventas>();
            this.Domicilio = new Domicilio();
            this.MedioDePago = new MedioDePago();
        }
        [Key]
        [Required]
        public int ID { get; set; }
        [Required(ErrorMessage = "Ingrese el Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese el Apellido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Ingrese el numero de telefono")]
        [Phone(ErrorMessage="Ingrese bien el numero de telefono")]
        public string NroTelefono { get; set; }
        [Required(ErrorMessage = "Ingrese el correo")]
        [EmailAddress(ErrorMessage = "Ingrese bien el correo electronico")]
        public string Email { get; set; }
        [Required(ErrorMessage="Ingrese la contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Ingrese la confirmacion de la contraseña")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Las contraseñas no son iguales, ingrese bien la confirmacion de la contraseña")]
        public string ConfirmPassword { get; set; }
        public virtual Domicilio Domicilio { get; set; }
        public virtual MedioDePago MedioDePago { get; set; }
        public virtual ICollection<Ventas> Ventas { get; set; }
    }
    
}