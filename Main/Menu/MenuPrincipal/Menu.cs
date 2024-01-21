public class Menu
{
    public int opcion;
    string? pin;

    public void MenuCredenciales()
    {
        Console.WriteLine("Ingrese su Tarjeta");

            Console.WriteLine("Ingrese su PIN (4 dígitos):");
            pin = Console.ReadLine();
    }

    

    public void MenuRecibo()
    {
        System.Console.WriteLine("Deseas el recibo de la transaccion? 1.Si/2.No");
    }
}