using Newtonsoft.Json;


namespace CosmosApi.Shared.Models
{
    public class MsgInstantiateContractResponse
    {
        public MsgInstantiateContractResponse() { }

        public MsgInstantiateContractResponse(string address, byte[] data)
        {
            this.address = address;
            this.data = data;
        }
        [JsonProperty("address")]
        public string address { get; set; } = null!;

        [JsonProperty("data")]
        public byte[] data { get; set; } = new byte[0];
    }
}
