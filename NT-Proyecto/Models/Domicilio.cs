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
            public string provincia { get; set; }
            public string barrio { get; set; }
        }
}
