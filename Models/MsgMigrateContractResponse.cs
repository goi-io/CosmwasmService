using Newtonsoft.Json;

namespace CosmosApi.Shared.Models
{
    public class MsgMigrateContractResponse
    {
        public MsgMigrateContractResponse() { }

        public MsgMigrateContractResponse(byte[] data)
        {
            this.data = data;
        }

        [JsonProperty("data")]
        public byte[] data { get; set; } = new byte[0];
    }
}
