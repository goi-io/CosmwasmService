using CosmosApi.Models;
using Newtonsoft.Json;

namespace CosmwasmApi.Models
{
    public class ClearAdminReq
    {
        public ClearAdminReq() { }
        public ClearAdminReq(BaseReq baseReq, string sender, string contract)
        {
            this.sender = sender;
            this.contract = contract;   
            this.BaseReq= baseReq;

        }
        [JsonProperty("base_req")]
        public BaseReq BaseReq { get; set; } = null!;

        [JsonProperty("sender")] public string sender { get; set; } = null!;
        [JsonProperty("contract")] public string contract { get; set; } = null!;

    }
}
