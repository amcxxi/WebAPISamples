namespace DemoConvencionUnderscore.API.Common
{
    public static class ExtensionsMethods
    {
        #region string
        public static string ToUnderscore(this string propertyName)
        {
            return System.Text.RegularExpressions.Regex.Replace(
                propertyName, @"([A-Z])([A-Z][a-z])|([a-z0-9])([A-Z])", "$1$3_$2$4").ToLower();
        }
        #endregion
    }
}