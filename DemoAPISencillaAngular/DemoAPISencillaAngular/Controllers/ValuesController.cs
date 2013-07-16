using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DemoAPISencillaAngular.Models;

namespace DemoAPISencillaAngular.Controllers
{
    public class ValuesController : ApiController
    {
        static List<Pais> paises = new List<Pais>()
            {
                new Pais(){Id = 1, Nombre = "Nicaragua"},
                new Pais(){Id = 2, Nombre = "Honduras"},
                new Pais(){Id = 3, Nombre = "Venezuela"},
                new Pais(){Id = 4, Nombre = "Colombia"},
                new Pais(){Id = 5, Nombre = "Argentina"},
            };

        // GET api/values
        public IEnumerable<Pais> Get()
        {
            return paises;
        }

        // GET api/values/5
        public Pais Get(int id)
        {
            return paises.FirstOrDefault(x => x.Id == id);
        }

        // POST api/values
        public void Post([FromBody]Pais pais)
        {
            paises.Add(pais);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Pais pais)
        {
            var item = paises.FirstOrDefault(x => x.Id == id);
            if (item == null) return;
            item.Nombre = pais.Nombre;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            paises.Remove(paises.First(x => x.Id == id));
        }
    }
}