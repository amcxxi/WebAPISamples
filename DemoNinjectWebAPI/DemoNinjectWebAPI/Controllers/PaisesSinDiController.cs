using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DemoNinjectWebAPI.Contracts;
using DemoNinjectWebAPI.Models;
using DemoNinjectWebAPI.Repositories;

namespace DemoNinjectWebAPI.Controllers
{
    public class PaisesSinDiController : ApiController
    {
        private readonly IPaisRepository repositorio;

        public PaisesSinDiController(IPaisRepository repositorio)
        {
            this.repositorio = repositorio;
        }

        public IEnumerable<Pais> Get()
        {
            return repositorio.GetAll();
        } 
    }
}
