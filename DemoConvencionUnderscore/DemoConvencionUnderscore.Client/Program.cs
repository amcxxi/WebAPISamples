using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DemoConvencionUnderscore.Client
{
    class Program
    {
        const string Url = "http://localhost:35551/api/values";

        static void Main(string[] args)
        {
            var paises = ObtenerPaises().Result;
            foreach (var pais in paises)
            {
                Console.WriteLine(pais);
            }
            Console.ReadKey();
        }

        public static async Task<IEnumerable<Pais>> ObtenerPaises()
        {
            List<Pais> paises;
            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync(Url);
                paises = await JsonConvert.DeserializeObjectAsync<List<Pais>>(response);
            }
            return paises;
        }
    }
}
