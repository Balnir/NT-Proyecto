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
        public string MDP { get; set; }
        public string nombreTitular { get; set;}
        public string enteEmisor { get; set; }
        public string banco { get; set; }
        public string codigoVerificador { get; set; }

    }
}