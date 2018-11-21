using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NT_Proyecto.Models
{
    public class AccountInitializer : DropCreateDatabaseAlways<MarketContext>
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
                },
                new Account
                {
                    Nombre = "David",
                    Apellido = "Gonzalez",
                    NroTelefono = "112329783",
                    Email = "David.Gonzalez@markost.com.ar",
                    Password = "asdf"
                },
                new Account
                {
                    Nombre = "Mariana",
                    Apellido = "Carballal",
                    NroTelefono = "1238132823",
                    Email = "Mariana.Carballal@markost.com.ar",
                    Password = "asdf"
                }
            };
            accounts.ForEach(s => context.Accounts.Add(s));
            context.SaveChanges();
        }
    }
}