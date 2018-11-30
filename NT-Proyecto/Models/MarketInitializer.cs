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
                    nombre = "Guillermo",
                    apellido = "Antun",
                    nroTelefono = "12398123987123",
                    email = "Guillermo.Antun@markost.com.ar",
                    password = "asdf"
                },
                new Account
                {
                    nombre = "David",
                    apellido = "Gonzalez",
                    nroTelefono = "112329783",
                    email = "David.Gonzalez@markost.com.ar",
                    password = "asdf"
                },
                new Account
                {
                    nombre = "Mariana",
                    apellido = "Carballal",
                    nroTelefono = "1238132823",
                    email = "Mariana.Carballal@markost.com.ar",
                    password = "asdf"
                }
            };
            var domicilios = new List<Domicilio>
            {
                new Domicilio
                {
                    provincia = "Capital Federal",
                    barrio = "Belgrano"
                },
                new Domicilio
                {
                    provincia = "Capital Federal",
                    barrio = "Saavedra"
                },
                new Domicilio
                {
                    provincia = "Capital Federal",
                    barrio = "Monserrat"
                },
            };
            var mediosdepagos = new List<MedioDePago>
            {
                new MedioDePago
                {
                    MDP = "Tarjeta Credito",
                    nombreTitular = "GUILLERMO ANTUN",
                    enteEmisor = "VISA",
                    banco = "BBVA",
                    codigoVerificador = "12345"
                },
                new MedioDePago
                {
                    MDP = "Tarjeta Debito",
                    nombreTitular = "GUILLERMO ANTUN",
                    enteEmisor = "VISA",
                    banco = "BBVA",
                    codigoVerificador = "54321"
                }
            };
            accounts.ForEach(s => context.Accounts.Add(s));
            domicilios.ForEach(s => context.Domicilios.Add(s));
            mediosdepagos.ForEach(s => context.MedioDePagos.Add(s));
            context.SaveChanges();
        }
    }
}