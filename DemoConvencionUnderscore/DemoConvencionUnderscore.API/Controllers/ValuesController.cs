using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DemoConvencionUnderscore.API.Models;

namespace DemoConvencionUnderscore.API.Controllers
{
    public class ValuesController : ApiController
    {
        static List<Pais> paises = new List<Pais>()
            {
                new Pais(){IdPais = 1, NombreCompleto = "Nicaragua"},
                new Pais(){IdPais = 2, NombreCompleto = "Honduras"},
                new Pais(){IdPais = 3, NombreCompleto = "Venezuela"},
                new Pais(){IdPais = 4, NombreCompleto = "Colombia"},
                new Pais(){IdPais = 5, NombreCompleto = "Argentina"},
            };

        // GET api/values
        public IEnumerable<Pais> Get()
        {
            return paises;
        }

        // GET api/values/5
        public HttpResponseMessage Get(int id)
        {
            return new HttpResponseMessage(HttpStatusCode.NotImplemented);
        }

        // POST api/values
        public HttpResponseMessage Post([FromBody]string value)
        {
            return new HttpResponseMessage(HttpStatusCode.NotImplemented);
        }

        // PUT api/values/5
        public HttpResponseMessage Put(int id, [FromBody]string value)
        {
            return new HttpResponseMessage(HttpStatusCode.NotImplemented);
        }

        // DELETE api/values/5
        public HttpResponseMessage Delete(int id)
        {
            return new HttpResponseMessage(HttpStatusCode.NotImplemented);
        }
    }
}