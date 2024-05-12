using System.Text.Json.Serialization;


namespace EjercicioClase1Modulo2.Models.User
{
    public class User
    {
        [JsonPropertyName("usuario")]
        public string Usuario { get; set; }

        [JsonPropertyName("amigos_usuario")]
        public List<string> AmigosUsuario { get; set; }

        [JsonPropertyName("notificaciones_usuario")]
        public bool NotificacionesUsuario { get; set; }


    }
}
