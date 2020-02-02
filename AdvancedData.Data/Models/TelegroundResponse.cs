using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AdvancedData.Data.Models
{

    /// <summary>
    /// https://app.quicktype.io/#l=cs&r=json2csharp
    /// To parse this JSON data do:
    /// var telegroundResponse = TelegroundResponse.FromJson(jsonString);
    /// </summary>
    public partial class TelegroundResponse
    {
        public TelegroundResponse()
        {}

        [JsonPropertyName("goto")]
        public long? Goto { get; set; }

        [JsonPropertyName("play")]
        public List<Play> Play { get; set; }

        [JsonPropertyName("inputs")]
        public Dictionary<string, long> Inputs { get; set; }

        [JsonPropertyName("variables")]
        public Dictionary<string, string> Variables { get; set; }
    }

   
    public partial class Play
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("album")]
        public long? Album { get; set; }

        [JsonPropertyName("sort")]
        public long? Sort { get; set; }
    }


    //public partial class Play
    //{
    //    [JsonPropertyName("type")]
    //    public string Type { get; set; }


    //    [JsonPropertyName("text", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Text { get; set; }

    //    [JsonPropertyName("album", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Album { get; set; }

    //    [JsonPropertyName("sort", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Sort { get; set; }
    //}


}