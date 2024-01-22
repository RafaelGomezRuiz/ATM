public class Menu
{
    static public int NumCuenta;
    static public int pin;

    public static void ShowMenuCredenciales()
    {
        Console.WriteLine("Ingrese su numero de cuenta: ");
            NumCuenta=int.Parse(Console.ReadLine()!);
            Console.WriteLine("Ingrese su PIN (4 dígitos):");
            pin = int.Parse(Console.ReadLine()!);
            ValidarUsuarios.Credenciales(NumCuenta,pin);
           
    }




}