using System.Collections.Generic;
using Newtonsoft.Json;

namespace AdvancedData.Data.Models
{

    /// <summary>
    /// https://app.quicktype.io/#l=cs&r=json2csharp
    /// To parse this JSON data do:
    /// var telegroundResponse = TelegroundResponse.FromJson(jsonString);
    /// </summary>
    public partial class TelegroundResponse
    {
        [JsonProperty("goto")]
        public long Goto { get; set; }

        [JsonProperty("play")]
        public List<Play> Play { get; set; }

        [JsonProperty("inputs")]
        public Dictionary<string, long> Inputs { get; set; }

        [JsonProperty("variables")]
        public Dictionary<string, string> Variables { get; set; }
    }

    public partial class Play
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        [JsonProperty("album", NullValueHandling = NullValueHandling.Ignore)]
        public long? Album { get; set; }

        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public long? Sort { get; set; }
    }


}