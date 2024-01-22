public class ValidarUsuarios{
    int conteo=0;
    public static void Credenciales(int numCuenta, int pin){
        List<Cuenta> cuentas=LeerJson.LeerCuenta();
        var cuentaUser=cuentas.FirstOrDefault(p => p.NumeroCuenta == numCuenta && p.Pin == pin);
        int nCuUser=cuentaUser.NumeroCuenta;
        int PinCuUser=cuentaUser.Pin;

            if (nCuUser ==numCuenta && PinCuUser ==pin)
            {
                MenuTransacciones.ShowMenuTransacciones();
            }
            // else if (cuentaUser(p =>p.NumeroCuenta==numCuenta && p.Pin!=pin))
            // {
            //     System.ConsUser("Pin incorrecto intentelo nuevamente");
                
            // }
            // else if (cuentaUser(p =>p.NumeroCuenta!=numCuenta && p.Pin==pin)){
            //     System.Console.WriteLine("Numero de cuenta incorrecto ");
            // }
            // else{
            //     System.Console.WriteLine("Numero de cuenta y pin incorrectos");
            // }
    }
}