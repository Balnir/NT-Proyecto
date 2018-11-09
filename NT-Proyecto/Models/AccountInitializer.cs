using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NT_Proyecto.Models
{
    public class AccountInitializer : DropCreateDatabaseAlways<AccountDBContext>
    {
        protected override void Seed(AccountDBContext context)
        {
            var accounts = new List<Account>
            {
                new Account
                {
                    Nombre = "Guillermo",
                    Apellido = "Antun",
                    NroTelefono = "12398123987123",
                    Email = "Guillermo.Antun@ventas.com.ar",
                    Password = "asdf"
                },
                new Account
                {
                    Nombre = "David",
                    Apellido = "Gonzalez",
                    NroTelefono = "112329783",
                    Email = "David.Gonzalez@ventas.com.ar",
                    Password = "asdf"
                },
                new Account
                {
                    Nombre = "Mariana",
                    Apellido = "Carballal",
                    NroTelefono = "1238132823",
                    Email = "Mariana.Carballal@ventas.com.ar",
                    Password = "asdf"
                }
            };
            accounts.ForEach(s => context.Accounts.Add(s));
            context.SaveChanges();
        }
    }
}