using CosmosApi.Models;
using CosmosApi.Shared.Models;
using Newtonsoft.Json;


namespace CosmwasmApi.Models
{
    public class StoreCodeReq
    {
        public StoreCodeReq() { }
        public StoreCodeReq(BaseReq baseReq, string sender, byte[] wasmByteCode, AccessConfig? instantiatePermsion)
        {
            this.sender = sender;
            this.wasmByteCode= wasmByteCode;
            this.instantiatePermission= instantiatePermsion;
            this.BaseReq= baseReq;  
        }


        [JsonProperty("base_req")]
        public BaseReq BaseReq { get; set; } = null!;

        [JsonProperty("sender")]
        public string sender { get; set; } = null!;

        [JsonProperty("wasmByteCode")]
        public byte[] wasmByteCode { get; set; } = null!;

        [JsonProperty("instantiatePermission")] public AccessConfig? instantiatePermission { get; set; } = null!;

    }
}
