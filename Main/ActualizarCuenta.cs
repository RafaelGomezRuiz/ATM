public class ActualizarCuenta{
    public static List<Cuenta> cuentasActualesJson;

    public static List<Cuenta>? ActualizarCuentaDespuesTransaccion(){
       cuentasActualesJson= LeerJson.LeerCuenta();

       return cuentasActualesJson;

    }

}