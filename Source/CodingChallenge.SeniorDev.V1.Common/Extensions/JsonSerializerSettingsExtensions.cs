using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CodingChallenge.SeniorDev.V1.Common.Extensions
{
    public static class JsonSerializerSettingsExtensions
    {
        /// Can be applied straight to the startup class
        public static void AddCustomSettings(this JsonSerializerSettings settings)
        {
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            settings.Formatting = Formatting.Indented;
        }

        /// Needed for middleware formatting
        public static JsonSerializerSettings GetSerializerSettings()
        {
            JsonSerializerSettings s = new JsonSerializerSettings();
            s.AddCustomSettings();
            return s;
        }
    }
}
