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
            var domicilios = new List<Domicilio>
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
            var mediosdepagos = new List<MedioDePago>
            {
                new MedioDePago
                {
                    MDP = "Tarjeta Credito",
                    NombreTitular = "GUILLERMO ANTUN",
                    EnteEmisor = "VISA",
                    Banco = "BBVA",
                    CodigoVerificador = "12345"
                },
                new MedioDePago
                {
                    MDP = "Tarjeta Debito",
                    NombreTitular = "GUILLERMO ANTUN",
                    EnteEmisor = "VISA",
                    Banco = "BBVA",
                    CodigoVerificador = "54321"
                }
            };
            accounts.ForEach(s => context.Accounts.Add(s));
            domicilios.ForEach(s => context.Domicilios.Add(s));
            mediosdepagos.ForEach(s => context.MedioDePagos.Add(s));
            context.SaveChanges();
        }
    }
}