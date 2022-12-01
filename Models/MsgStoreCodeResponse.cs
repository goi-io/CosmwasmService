using Newtonsoft.Json;


namespace CosmosApi.Shared.Models
{
    public class MsgStoreCodeResponse
    {
        public MsgStoreCodeResponse() { }

        public MsgStoreCodeResponse(ulong codeId)
        {
            this.codeId = codeId;
        }

        [JsonProperty(PropertyName = "code_id")]
        public ulong codeId { get; set; }
    }
}
