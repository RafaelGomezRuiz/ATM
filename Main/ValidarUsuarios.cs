public class ValidarUsuarios{
    public static int conteo=0;

    public static Cuenta BuscarCuenta(int numCuenta){
        List<Cuenta> cuentas=LeerJson.LeerCuenta();
        
        var CuentaUsuario=cuentas.FirstOrDefault(p => p.NumeroCuenta==numCuenta);
        return CuentaUsuario;
    }

    public static bool ExisteCuenta(int numCuenta){

        List<Cuenta> cuentas=LeerJson.LeerCuenta();
        
        var CuentaUsuario=cuentas.FirstOrDefault(p => p.NumeroCuenta==numCuenta);
         if(CuentaUsuario!=null){
            return true;
         }
         else{
            return false;
        }
    }
    public static bool CuentaHabilitada(Cuenta CuentaUsuario){

        
         if(CuentaUsuario.EstadoCuenta){
            return true;
         }
         else{
            return false;
        }
    }

    public static void Credenciales(Cuenta CuentaUsuario, int pin)
{
    int PinUser = CuentaUsuario.Pin;

    if (PinUser == pin)
    {
        MenuTransacciones.ShowMenuTransacciones();
        MenuPrincipal.buclePin = false;
    }
    else if (PinUser != pin)
    {
        if (conteo < 3)
        {
            Console.WriteLine("Pin incorrecto, inténtelo nuevamente");
            conteo++;
            
        }
        else if (conteo >= 3)
        {
            System.Console.WriteLine("Haz intentado más de tres veces, su cuenta ha sido inhabilitada.");
            
            CuentaUsuario.EstadoCuenta = false;
            

            MenuPrincipal.buclePin = false;
        }
    }
}
}
