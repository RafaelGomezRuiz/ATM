public class MenuDepositar{
    public static int numCuentaDestino;
    public static Cuenta? cuentaDestino;
    public static double monto;

    public static void ShowMenuDepositar()
    {
        System.Console.WriteLine("Ingresa el numero de cuenta :");
        numCuentaDestino=int.Parse(Console.ReadLine()!);
        ValidarUsuarios.ExisteCuenta(numCuentaDestino);

        if(ValidarUsuarios.ExisteCuenta(numCuentaDestino)){

            cuentaDestino=ValidarUsuarios.BuscarCuenta(numCuentaDestino);
            System.Console.WriteLine("Ingresa el monto: ");
            monto=double.Parse(Console.ReadLine()!);

            if(MenuPrincipal.cuentaUsuarioLogeado.Saldo>monto){
            Transacciones.Depositar(MenuPrincipal.cuentaUsuarioLogeado,cuentaDestino, monto); //este metodo recibe la cuenta que se valido al iniciar sesion
            }
            else{
                System.Console.WriteLine("No tienes saldo suficiente");
            }
        }
        else{
            System.Console.WriteLine("No existe cuenta con ese numero");
        }
    }
}