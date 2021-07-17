using System;
namespace ProjectXTwo.Animacion
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Animacion
    {
        [JsonProperty("accion")]
        public string Accion { get; set; }

        [JsonProperty("objeto")]
        public string Objeto { get; set; }

        [JsonProperty("tiempomili")]
        public int Tiempomili { get; set; }


        public Escenario escenario;
    }

    public partial class Animacion
    {
        public static List<Animacion> FromJson(string json) => JsonConvert.DeserializeObject<List<Animacion>>(json, ProjectXTwo.Animacion.Converter.Settings);

        public async Task  animar() {

           await ControlAnimador.animar(this);
           

        }


    }

    public static class Serialize
    {
        public static string ToJson(this List<Animacion> self) => JsonConvert.SerializeObject(self, ProjectXTwo.Animacion.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
