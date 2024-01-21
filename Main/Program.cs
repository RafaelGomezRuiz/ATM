namespace ATM;
using System.Text.Json;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var usuario = new Usuario
            {
                Nombre="rafael gomez",
                Cedula="121ds",
                Correo="ds@gmail.com",
                Telefono = 806954
            };

            string jsonString = JsonSerializer.Serialize(usuario);

            Console.WriteLine(jsonString);
    }
}
