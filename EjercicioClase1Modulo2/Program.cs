using System.Text.Json;
using EjercicioClase1Modulo2.Models.Cart;
using EjercicioClase1Modulo2.Models.Estadistica;
using EjercicioClase1Modulo2.Models.User;


namespace EjercicioClase1Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio clase 1 modulo 2");
            // Consigna:
            // En la ruta principal del proyecto hay 3 archivos json, para cada uno de ellos crear las clases que consideren necesarias para poder deserializar correctamente
            // Uso: JsonSerializer.Deserialize<ClaseCreada>(data);

            var pathEjercicio1 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio1.json";
            var pathEjercicio2 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio2.json";
            var pathEjercicio3 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio3.json";

            var dataEjercicio1 = File.ReadAllText(pathEjercicio1);
            var dataEjercicio2 = File.ReadAllText(pathEjercicio2);
            var dataEjercicio3 = File.ReadAllText(pathEjercicio3);

            var usuario = JsonSerializer.Deserialize<User>(dataEjercicio1);


            var estadistica = JsonSerializer.Deserialize<Estadistica>(dataEjercicio2);

            var cart = JsonSerializer.Deserialize<Cart>(dataEjercicio3);

            Console.WriteLine(usuario?.Usuario);

            Console.WriteLine(estadistica?.Estadisticas[0].Equipo);

            Console.WriteLine(cart?.Productos[0].Nombre);





        }
    }
}