public class MenuPrincipal
{
    static public int NumCuenta;
    static public int pin;
    public  static  bool buclePin=true;

    public static void ShowMenuCredenciales()
    {
        while(true){
        Console.WriteLine("Ingrese su numero de cuenta: ");
            NumCuenta=int.Parse(Console.ReadLine()!);
            ValidarUsuarios.BuscarCuenta(NumCuenta);

            if (ValidarUsuarios.ExisteCuenta(NumCuenta) && ValidarUsuarios.CuentaHabilitada(ValidarUsuarios.BuscarCuenta(NumCuenta)) )
            {
                ValidarUsuarios.BuscarCuenta(NumCuenta);
                    while(buclePin==true){
                        Console.WriteLine("Ingrese su PIN (4 dígitos):");
                        pin = int.Parse(Console.ReadLine()!);
                        ValidarUsuarios.Credenciales(ValidarUsuarios.BuscarCuenta(NumCuenta),pin);
                        }
                    break;
                break;
            }
            else if (!ValidarUsuarios.CuentaHabilitada(ValidarUsuarios.BuscarCuenta(NumCuenta)) )
            {
                System.Console.WriteLine("Su cuenta esta inhabilitada");
                break;
            }
            else{
                System.Console.WriteLine("No existe una cuenta con ese numero, intentalo de nuevo: ");
                continue;
            }
        }

            
           
    }




}