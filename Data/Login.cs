//using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using Newtonsoft.Json;

namespace VoeAirlines.Data {
    public class Login {

        [JsonProperty("Usuario")]

        public string? Usuario{ get; set; }
        
        [JsonProperty ("DataCriacao")]
        public DateTime DataCriacao { get; set; }
    }
}