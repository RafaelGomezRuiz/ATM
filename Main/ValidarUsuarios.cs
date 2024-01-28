public class ValidarUsuarios{
    public static int conteo=0;
    static Cuenta? CuentaUsuario;
    
    public static Cuenta BuscarCuenta(int numCuenta){

        //buscar usuario que tenga cuentas y que el numero sea igual .... Tenemos que usar any para que sea booleana la respuesta ya que firstOrDefault devuelve un tipo Cuenta
        Usuario? cuenta=GuardarJson.UsuariosActualesJson.FirstOrDefault(u=>u.Productos.Cuentas !=null && u.Productos.Cuentas.Any(b => b.NumeroCuenta==numCuenta));
        if(cuenta != null && cuenta!= null){
            CuentaUsuario=cuenta.Productos.Cuentas.FirstOrDefault(p => p.NumeroCuenta==numCuenta);
            if(CuentaUsuario!=null){  
                return CuentaUsuario;    
                }
            else{
                System.Console.WriteLine("No existe cuenta con ese numero");
                return null;
                }
        }
        else{
                    System.Console.WriteLine("No existe cuenta con ese numero");
                    return null;
                }
    }


    public static bool CuentaHabilitada(Cuenta CuentaUsuario){

        
         if(CuentaUsuario.EstadoCuenta==true){
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
        //MenuTransacciones.ShowMenuTransacciones();
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
            //GuardarJson.RemoverCuentaJson(CuentaUsuario);
            CuentaUsuario.EstadoCuenta = false;
            //GuardarJson.ActualizarCuentasDespuesTransaccion(CuentaUsuario);
            

            MenuPrincipal.buclePin = false;
        }
    }
}
}
