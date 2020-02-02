using System.Collections.Generic;
//using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace AdvancedData.Data.Models
{
    
    /// <summary>
    /// To parse this JSON data do:
    /// var telegroundRequest = TelegroundRequest.FromJson(jsonString);
    /// </summary>
    public partial class TelegroundRequest
    {
        
        [JsonPropertyName("call_id")] public string CallId { get; set; }

        [JsonPropertyName("cid")] public string Cid { get; set; }

        [JsonPropertyName("branch_data:")]
        public IEnumerable<BranchData> BranchData { get; set; }

        [JsonPropertyName("variables")] public Dictionary<string, string> Variables { get; set; }
    }

    public partial class BranchData
    {
        [JsonPropertyName("branch")] public long Branch { get; set; }

        [JsonPropertyName("input")] public long Input { get; set; }
    }

    
}