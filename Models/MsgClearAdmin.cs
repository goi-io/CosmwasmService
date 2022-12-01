using Newtonsoft.Json;
using CosmosApi.Shared.Models;

namespace CosmwasmApi.Models
{
    public class MsgClearAdmin : IMsg
    {
        public MsgClearAdmin() { }
        public MsgClearAdmin(string sender, string contract)
        {
            this.sender = sender;
            this.contract = contract;   
   

        }

        [JsonProperty("sender")] public string sender { get; set; } = null!;
        [JsonProperty("contract")] public string contract { get; set; } = null!;

        public object SignBytesObject()
        {
            return this;
        }
    }
}
