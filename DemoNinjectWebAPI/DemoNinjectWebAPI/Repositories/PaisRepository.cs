using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoNinjectWebAPI.Contracts;
using DemoNinjectWebAPI.Models;

namespace DemoNinjectWebAPI.Repositories
{
    public class PaisRepository:IPaisRepository
    {
        private readonly IEnumerable<Pais> paises = new List<Pais>()
            {
                new Pais() { Id = 1, Nombre = "Nicaragua" },
                new Pais() { Id = 2, Nombre = "Colombia" },
                new Pais() { Id = 3, Nombre = "España" },
                new Pais() { Id = 4, Nombre = "Francia" },
                new Pais() { Id = 5, Nombre = "Portugal" }
            };

        public IEnumerable<Pais> GetAll()
        {
            return paises.AsQueryable();
        }
    }
}