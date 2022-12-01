using CosmosApi.Models;
using Newtonsoft.Json;
using CosmosApi.Shared.Models;

namespace CosmwasmApi.Models
{
    public class MsgExecuteContract : IMsg
    {
        public MsgExecuteContract  () { }
        public MsgExecuteContract(string sender, string contract, byte[] msg, IList<Coin> funds)
        {
            this.sender = sender;
            this.contract = contract;   
            this.msg = msg;
            this.funds = funds;
  
        }




        [JsonProperty("sender")]
        public string sender { get; set; } = null!;

        [JsonProperty("contract")]
        public string contract { get; set; } = null!;

        [JsonProperty("msg")]
        public byte[] msg { get; set; } = null!;


        [JsonProperty("funds")] public IList<Coin> funds { get; set; } = null!;

        public object SignBytesObject()
        {
            return this;
        }
    }
}
