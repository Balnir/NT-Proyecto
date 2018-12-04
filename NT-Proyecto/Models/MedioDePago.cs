using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;

namespace NT_Proyecto.Models
{
    public class MedioDePago
    {
        [Key]
        [Required]
        public int MDPId { get; set; }
        [Required(ErrorMessage = "Ingrese el numero de la tarjeta")]
        [StringLength(16, ErrorMessage = "Ingrese bien el numero de la tarjeta")]
        public string nroTarjeta { get; set; }
        [Required(ErrorMessage = "Ingrese el nombre del titular")]
        public string nombreTitular { get; set; }
        [Required(ErrorMessage = "Elija el ente emisor")]
        public EnteEmisor nombreEmisor { get; set; }
        [Required(ErrorMessage = "Ingrese la fecha de vencimiento formato: MMAA")]
        [StringLength(4, ErrorMessage = "Ingrese bien la fecha de vencimiento de la tarjeta")]
        public string vencimiento { get; set; }
        [Required(ErrorMessage = "Ingrese el codigo verificador de la tarjeta")]
        [StringLength(3, ErrorMessage = "Ingrese bien el codigo verificador de la tarjeta")]
        public string codigoVerificador { get; set; }

        //public MedioDePago (int MDPId, string nroTarjeta, string nombreTitular, EnteEmisor nombreEmisor, string vencimiento, string codigoVerificador)
        //{
        //    this.MDPId = MDPId;
        //    this.nroTarjeta = nroTarjeta;
        //    this.nombreTitular = nombreTitular;
        //    this.nombreEmisor = nombreEmisor;
        //    this.vencimiento = vencimiento;
        //    this.codigoVerificador = codigoVerificador;
        //}

    }
    public enum EnteEmisor
    {
        Visa,
        Master_Card,
        American_Express
    }
}