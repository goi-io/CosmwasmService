using Newtonsoft.Json;


namespace CosmosApi.Shared.Models
{
    public class MsgExecuteContractResponse
    {
        public MsgExecuteContractResponse() { }

        public MsgExecuteContractResponse(byte[] data)
        {
            this.data = data;
        }

        [JsonProperty("data")]

        public byte[] data { get; set; } = new byte[0];
    }
}
