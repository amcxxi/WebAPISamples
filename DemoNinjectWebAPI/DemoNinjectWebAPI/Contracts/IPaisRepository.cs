using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DemoNinjectWebAPI.Models;

namespace DemoNinjectWebAPI.Contracts
{
    public interface IPaisRepository
    {
        IEnumerable<Pais> GetAll();
    }
}
