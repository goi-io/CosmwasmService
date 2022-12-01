using CosmosApi.Models;
using Newtonsoft.Json;


namespace CosmwasmApi.Models
{
    public class MigrateContractReq
    {
        public MigrateContractReq() { }
        public MigrateContractReq(BaseReq baseReq, string sender, string contract, ulong codeId, byte[] msg)
        {
            this.sender = sender;
            this.contract = contract;   
            this.codeId = codeId;   
            this.msg = msg; 
            this.BaseReq= baseReq;

        }

        [JsonProperty("base_req")]
        public BaseReq BaseReq { get; set; } = null!;

        [JsonProperty("sender")]
        public string sender { get; set; } = null!;

        [JsonProperty("contract")]
        public string contract { get; set; } = null!;

        [JsonProperty("codeId")]
        public ulong codeId { get; set; }

        [JsonProperty("msg")]
        public byte[] msg { get; set; } = null!;

    }
}
