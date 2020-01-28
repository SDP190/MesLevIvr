using System.Collections.Generic;
using Newtonsoft.Json;

namespace AdvancedData.Data.Models
{
    
    /// <summary>
    /// To parse this JSON data do:
    /// var telegroundRequest = TelegroundRequest.FromJson(jsonString);
    /// </summary>
    public partial class TelegroundRequest
    {
        [JsonProperty("call_id")] public string CallId { get; set; }

        [JsonProperty("cid")] public string Cid { get; set; }

        [JsonProperty("branch_data:")] public List<BranchData> BranchData { get; set; }

        [JsonProperty("variables")] public Dictionary<string, string> Variables { get; set; }
    }

    public partial class BranchData
    {
        [JsonProperty("branch")] public long Branch { get; set; }

        [JsonProperty("input")] public long Input { get; set; }
    }

    
}