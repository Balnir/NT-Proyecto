using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NT_Proyecto.Models
{
    public class DomicilioInitializer : DropCreateDatabaseAlways<MarketContext>
    {
        protected override void Seed(MarketContext context)
        {
            var accounts = new List<Domicilio>
            {
                new Domicilio
                {
                    Provincia = "Capital Federal",
                    Barrio = "Belgrano"
                },
                new Domicilio
                {
                    Provincia = "Capital Federal",
                    Barrio = "Saavedra"
                },
                new Domicilio
                {
                    Provincia = "Capital Federal",
                    Barrio = "Monserrat"
                },
            };
            accounts.ForEach(s => context.Domicilios.Add(s));
            context.SaveChanges();
        }

    }
}
