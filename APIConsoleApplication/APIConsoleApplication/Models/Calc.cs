using Newtonsoft.Json;

namespace APIConsoleApplication.Models
{
    class Calc
    {
        [JsonProperty(PropertyName = "parametros")]
        public int parametros { get; set; }
        [JsonProperty(PropertyName = "resultado")]
        public string resultado { get; set; }

        public override string ToString()
        {
            return resultado;
        }
    }
}
