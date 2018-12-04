using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NT_Proyecto.Models
{
    public class MarketInitializer : DropCreateDatabaseAlways<MarketContext>
    {
        protected override void Seed(MarketContext context)
        {
            var accounts = new List<Account>
            {
                new Account
                {
                    Nombre = "Guillermo",
                    Apellido = "Antun",
                    NroTelefono = "12398123987123",
                    Email = "Guillermo.Antun@markost.com.ar",
                    Password = "asdf"
                    //domicilio = new Domicilio(1,Barrio.Almagro, "callefalsa1234"),
                    //medioDePago = new MedioDePago(1,"1234567890123456","GUILLERMOANTUN",EnteEmisor.Visa,"0121","111")
                },
                new Account
                {
                    Nombre = "David",
                    Apellido = "Gonzalez",
                    NroTelefono = "112329783",
                    Email = "David.Gonzalez@markost.com.ar",
                    Password = "asdf"
                    //domicilio = new Domicilio(2,Barrio.Almagro, "callefalsa1233"),
                    //medioDePago = new MedioDePago(2,"1111222233334444","DAVIDGONZALEZ",EnteEmisor.Visa,"0122","222")
                },
                new Account
                {
                    Nombre = "Mariana",
                    Apellido = "Carballal",
                    NroTelefono = "1238132823",
                    Email = "Mariana.Carballal@markost.com.ar",
                    Password = "asdf"
                    //domicilio = new Domicilio(3,Barrio.Almagro, "callefalsa1232"),
                    //medioDePago = new MedioDePago(3,"6543210987654321","MARIANACARBALLAL",EnteEmisor.Visa,"0123","333")
                }
            };
            accounts.ForEach(s => context.Accounts.Add(s));
            context.SaveChanges();
        }
    }
}