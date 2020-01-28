using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedData.Data.Helpers
{

    public partial class TelegroundRequest
    {
        public static Models.TelegroundRequest FromJson(string json) =>
            JsonConvert.DeserializeObject<Models.TelegroundRequest>(json, Converter.Settings);
    }

    public partial class TelegroundResponse
    {
        public static Models.TelegroundResponse FromJson(string json) =>
            JsonConvert.DeserializeObject<Models.TelegroundResponse>(json, Converter.Settings);
    }


    public static class Serialize
    {
        public static string ToJson(this Models.TelegroundRequest self) =>
            JsonConvert.SerializeObject(self, Converter.Settings);

        public static string ToJson(this Models.TelegroundResponse self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    /// <summary>
    /// https://app.quicktype.io/
    /// </summary>
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter {DateTimeStyles = DateTimeStyles.AssumeUniversal}
            },
        };
    }
}