using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NT_Proyecto.Models
{
    public class MedioDePago
    {
        public string MDP { get; set; }
        public string NombreTitular { get; set;}
        public string EnteEmisor { get; set; }
        public string Banco { get; set; }
        public string CodigoVerificador { get; set; }

    }
}