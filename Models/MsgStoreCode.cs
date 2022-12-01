using Newtonsoft.Json;
using CosmosApi.Shared.Models;

namespace CosmwasmApi.Models
{
    public class MsgStoreCode : IMsg
    {
        public MsgStoreCode() { }
        public MsgStoreCode(string sender, byte[] wasmByteCode, AccessConfig? instantiatePermsion)
        {
            this.sender = sender;
            this.wasmByteCode= wasmByteCode;
            this.instantiatePermission= instantiatePermsion;
        }


        [JsonProperty("sender")]
        public string sender { get; set; } = null!;

        [JsonProperty("wasmByteCode")]
        public byte[] wasmByteCode { get; set; } = null!;

        [JsonProperty("instantiatePermission")] public AccessConfig? instantiatePermission { get; set; } = null!;

        public object SignBytesObject()
        {
            return this;
        }
    }
}
