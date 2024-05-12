using System.Text.Json.Serialization;


namespace EjercicioClase1Modulo2.Models.Estadistica
{
    public class Estadistica
    {
        [JsonPropertyName("estadistica")]
        public List<EstadisticaElement> Estadisticas { get; set; }
    }

    public class EstadisticaElement
    {
        [JsonPropertyName("equipo")]
        public string Equipo { get; set; }

        [JsonPropertyName("jugadores")]
        public List<Jugador> Jugadores { get; set; }

        [JsonPropertyName("campeon")]
        public bool Campeon { get; set; }
    }

    public class Jugador
    {
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }

        [JsonPropertyName("kills")]
        public long Kills { get; set; }

        [JsonPropertyName("death")]
        public long Death { get; set; }
    }
}

