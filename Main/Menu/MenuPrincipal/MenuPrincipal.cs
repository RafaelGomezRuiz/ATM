public class MenuPrincipal
{
    static public int NumCuenta;
    static public int pin;

    public static void ShowMenuCredenciales()
    {
        Console.WriteLine("Ingrese su numero de cuenta: ");
            NumCuenta=int.Parse(Console.ReadLine()!);
            ValidarUsuarios.BuscarCuenta(NumCuenta);

            if (ValidarUsuarios.ExisteCuenta(NumCuenta))
            {
                ValidarUsuarios.BuscarCuenta(NumCuenta);
                Console.WriteLine("Ingrese su PIN (4 dígitos):");
                pin = int.Parse(Console.ReadLine()!);
                ValidarUsuarios.Credenciales(ValidarUsuarios.BuscarCuenta(NumCuenta),pin); 
            }
            else{
                System.Console.WriteLine("No existe una cuenta con ese numero");
            }

            
           
    }




}