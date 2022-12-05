using Newtonsoft.Json;

namespace VoeAirlinesBlazorApi3.Data
{
    public class Aeronave
    {
        [JsonProperty("Usuario")]

        public string? Usuario { get; set; }

        [JsonProperty("DataCriacao")]

        public DateTime DataCriacao { get; set; }
    }
}