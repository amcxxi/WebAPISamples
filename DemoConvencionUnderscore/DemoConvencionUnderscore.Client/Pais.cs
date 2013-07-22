using Newtonsoft.Json;

namespace DemoConvencionUnderscore.Client
{
    class Pais
    {
        [JsonProperty(PropertyName = "id_pais")]
        public int IdPais { get; set; }
        [JsonProperty(PropertyName = "nombre_completo")]
        public string NombreCompleto { get; set; }

        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}
