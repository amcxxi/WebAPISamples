using Newtonsoft.Json.Serialization;

namespace DemoConvencionUnderscore.API.Common
{
    public class UnderscoreContractResolver:DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            return propertyName.ToUnderscore();
        }
    }
}