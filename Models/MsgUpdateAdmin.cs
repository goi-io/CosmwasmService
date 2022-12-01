using Newtonsoft.Json;
using CosmosApi.Shared.Models;

namespace CosmwasmApi.Models
{
    public class MsgUpdateAdmin : IMsg
    {
     
        public MsgUpdateAdmin () { }

        public MsgUpdateAdmin(string sender, string newAdmin, string contract)
        {
            this.sender = sender;
            this.newAdmin = newAdmin;
            this.contract = contract;

        }



        [JsonProperty("sender")] public string sender { get; set; } = null!;

        [JsonProperty("sender")] public string newAdmin { get; set; } = null!;

        [JsonProperty("sender")] public string contract { get; set; } = null!;

        public object SignBytesObject()
        {
            return this;
        }
    }
}
