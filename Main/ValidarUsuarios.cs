public class ValidarUsuarios{
    int conteo=0;

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

    public static void Credenciales(Cuenta CuentaUsuario, int pin){

        int PinUser=CuentaUsuario.Pin;

        //Para hacerlo con where se tomarian esas 4 lineas
        //var cuentasList=cuentas.Where(p =>p.NumeroCuenta==numCuenta && p.Pin==pin).ToList();
        //var cuentaUser = cuentasList.First(); // Obtener el primer elemento de la lista
        //int nCuUser = cuentaUser.NumeroCuenta;
        //int pinCuUser = cuentaUser.Pin;
       
            

            if ( PinUser ==pin)
            {
                MenuTransacciones.ShowMenuTransacciones();
            }
            else if ( PinUser !=pin)
            {
                Console.WriteLine("Pin incorrecto intentelo nuevamente");
                
            }
            
    }
}