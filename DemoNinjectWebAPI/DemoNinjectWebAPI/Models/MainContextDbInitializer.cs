using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoNinjectWebAPI.Models
{
    public class MainContextDbInitializer : DropCreateDatabaseIfModelChanges<MainContext>
    {
        protected override void Seed(MainContext contexto)
        {
            contexto.Paises.Add(new Pais() { Nombre = "Nicaragua" });
            contexto.Paises.Add(new Pais() { Nombre = "Colombia" });
            contexto.Paises.Add(new Pais() { Nombre = "España" });
            contexto.Paises.Add(new Pais() { Nombre = "Francia" });
            contexto.Paises.Add(new Pais() { Nombre = "Portugal" });
        }
    }
}