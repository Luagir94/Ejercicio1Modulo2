using System.Text.Json.Serialization;


namespace EjercicioClase1Modulo2.Models.Cart
{
	public class Cart
	{
		[JsonPropertyName("productos")]
		public List<Producto> Productos { get; set; }
	}

	public class Producto
	{
		[JsonPropertyName("nombre")]
		public string Nombre { get; set; }

		[JsonPropertyName("precio")]
		public double Precio { get; set; }

		[JsonPropertyName("existencias")]
		public long Existencias { get; set; }

		[JsonPropertyName("descuento_disponible")]
		public bool DescuentoDisponible { get; set; }

		[JsonPropertyName("etiquetas")]
		public List<string> Etiquetas { get; set; }

		[JsonPropertyName("detalles")]
		public Detalles Detalles { get; set; }
	}

	public class Detalles
	{
		[JsonPropertyName("peso")]
		public double Peso { get; set; }

		[JsonPropertyName("dimensiones")]
		public Dimensiones Dimensiones { get; set; }
	}

	public class Dimensiones
	{
		[JsonPropertyName("alto")]
		public long Alto { get; set; }

		[JsonPropertyName("ancho")]
		public long Ancho { get; set; }

		[JsonPropertyName("profundidad")]
		public long Profundidad { get; set; }
	}
}