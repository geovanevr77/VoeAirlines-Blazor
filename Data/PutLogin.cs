using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VoeAirlinesBlazor.Data
{
    public class PutLogin
    {
    [JsonProperty ("Usuario")]
    public string? Usuario { get; set; }

    [JsonProperty ("Senha")]
    public string? Senha { get; set; }

    [JsonProperty ("DataCriacao")]
    public DateTime DataCriacao { get; set; } = DateTime.Now;
    }
}