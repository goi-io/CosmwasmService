using CosmosApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmwasmApi.Models
{
    public class UpdateAdminReq
    {
     
        public UpdateAdminReq() { }

        public UpdateAdminReq(BaseReq baseReq, string sender, string newAdmin, string contract)
        {
            this.sender = sender;
            this.newAdmin = newAdmin;
            this.contract = contract;
            this.BaseReq= baseReq;

        }


        [JsonProperty("base_req")]
        public BaseReq BaseReq { get; set; } = null!;

        [JsonProperty("sender")] public string sender { get; set; } = null!;

        [JsonProperty("sender")] public string newAdmin { get; set; } = null!;

        [JsonProperty("sender")] public string contract { get; set; } = null!;

    }
}
