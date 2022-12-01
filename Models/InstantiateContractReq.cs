using CosmosApi.Models;
using Newtonsoft.Json;

namespace CosmwasmApi.Models
{
    public class InstantiateContractReq
    {
        public InstantiateContractReq() { }
        public InstantiateContractReq(BaseReq baseReq, string sender, string admin, ulong codeId, string label, byte[] msg, IList<Coin> funds)
        {
            this.sender= sender;
            this.admin= admin;
            this.codeId= codeId;    
            this.label= label;
            this.msg= msg;
            this.funds= funds;
            this.BaseReq= baseReq;

        }

        [JsonProperty("base_req")]
        public BaseReq BaseReq { get; set; } = null!;

        [JsonProperty("sender")] public string sender { get; set; } = null!;

        [JsonProperty("admin")] public string admin { get; set; } = null!;

        [JsonProperty("codeId")]    
        public ulong codeId { get; set; }   

        [JsonProperty("label")] public string label { get; set; } = null!;

        [JsonProperty("msg")] public byte[] msg { get; set; } = null!;

        [JsonProperty("funds")] public IList<Coin> funds { get; set; } = null!;

    }
}
