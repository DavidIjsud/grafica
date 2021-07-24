

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
        [JsonProperty("objeto")]
        public string Objeto { get; set; }

        [JsonProperty("acciones")]
        public List<Accione> Acciones { get; set; }

        public Escenario escenario;
    }

    public partial class Accione
    {
        [JsonProperty("accion")]
        public string Accion { get; set; }

        [JsonProperty("tiempo")]
        public int Tiempo { get; set; }
    }

    public partial class Animacion
    {
        public static List<Animacion> FromJson(string json) => JsonConvert.DeserializeObject<List<Animacion>>(json, ProjectXTwo.Animacion.Converter.Settings);
        public void animar()
        {

            ControlAnimador.animar(this);


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
