using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DemoNinjectWebAPI.Contracts;
using DemoNinjectWebAPI.Models;

namespace DemoNinjectWebAPI.Controllers
{
    public class PaisesController : ApiController
    {
        private readonly IPaisRepository repositorio;

        public PaisesController(IPaisRepository repositorio)
        {
            this.repositorio = repositorio;
        }

        public IEnumerable<Pais> Get()
        {
            return repositorio.GetAll();
        } 
    }
}
