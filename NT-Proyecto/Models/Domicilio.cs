using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;

namespace NT_Proyecto.Models
{
    public class Domicilio
        {
            [Key]
            [Required]
            public int DomId { get; set; }
            [Required]
            public Barrio Barrio { get; set; }
            [Required(ErrorMessage="Ingrese una direccion")]
            public string Direccion { get; set; }

            //public Domicilio (int DomId, Barrio Barrio, string direccion)
            //{
            //    this.DomId = DomId;
            //    this.Barrio = Barrio;
            //    this.direccion = direccion;
            //}
        }
    public enum Barrio
    {
        Agronomía,
        Almagro,
        Balvanera,
        Barracas,
        Belgrano,
        Boedo,
        Caballito,
        Chacarita,
        Coghlan,
        Colegiales,
        Constitución,
        Flores,
        Floresta,
        La_Boca,
        La_Paternal,
        Liniers,
        Mataderos,
        Monte_Castro,
        Monserrat,
        Nueva_Pompeya,
        Núñez,
        Palermo,
        Parque_Avellaneda,
        Parque_Chacabuco,
        Parque_Chas,
        Parque_Patricios,
        Puerto_Madero,
        Recoleta,
        Retiro,
        Saavedra,
        San_Cristóbal,
        San_Nicolás,
        San_Telmo,
        Vélez_Sársfield,
        Versalles,
        Villa_Crespo,
        Villa_del_Parque,
        Villa_Devoto,
        Villa_General_Mitre,
        Villa_Lugano,
        Villa_Luro,
        Villa_Ortúzar,
        Villa_Pueyrredón,
        Villa_Real,
        Villa_Riachuelo,
        Villa_Santa_Rita,
        Villa_Soldati,
        Villa_Urquiza,
    }
}
