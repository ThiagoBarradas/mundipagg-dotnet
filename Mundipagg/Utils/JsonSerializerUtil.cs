using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Utils
{
    /// <summary>
    /// Custom json serializer
    /// </summary>
    public class JsonSerializerUtil
    {
        #region Public Properties

        /// <summary>
        /// Camel case settings
        /// </summary>
        public static JsonSerializerSettings CamelCaseSettings
        {
            get
            {
                var settings = new JsonSerializerSettings();

                settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                settings.Formatting = Formatting.Indented;
                settings.Converters.Add(new StringEnumConverter());
                settings.NullValueHandling = NullValueHandling.Ignore;

                return settings;
            }
        }

        /// <summary>
        /// Camel case settings
        /// </summary>
        public static JsonSerializerSettings LowerCaseSettings
        {
            get
            {
                var settings = new JsonSerializerSettings();

                settings.ContractResolver = new DefaultContractResolver()
                {
                    NamingStrategy = new LowerCaseNamingResolver()
                };
                settings.Formatting = Formatting.Indented;
                settings.Converters.Add(new StringEnumConverter());
                settings.NullValueHandling = NullValueHandling.Ignore;

                return settings;
            }
        }

        /// <summary>
        /// Snake case settings
        /// </summary>
        public static JsonSerializerSettings SnakeCaseSettings
        {
            get
            {
                var settings = new JsonSerializerSettings();

                settings.ContractResolver = new DefaultContractResolver()
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                };
                settings.Formatting = Formatting.Indented;
                settings.Converters.Add(new StringEnumConverter());
                settings.NullValueHandling = NullValueHandling.Ignore;

                return settings;
            }
        }

        #endregion Public Properties
    }

    /// <summary>
    /// Resolve property names to lowercase only
    /// </summary>
    public class LowerCaseNamingResolver : NamingStrategy
    {
        #region Protected Methods

        protected override string ResolvePropertyName(string name)
        {
            return name.ToLower();
        }

        #endregion Protected Methods
    }
}