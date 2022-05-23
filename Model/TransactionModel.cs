using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankApp.Model
{
    public class TransactionModel
    {
        [JsonProperty("operation")]
        public string operation { get; set; }

        [JsonProperty("unit-cost")]
        public decimal unitCost { get; set; }

        [JsonProperty("quantity")]
        public int quantity { get; set; }
    }
}
