public class Transacciones{
    
    public static Operaciones operacion= new Operaciones(); //El problema es que es estatico tu yo del futuro

    public static DateTime fechaActual=DateTime.Now;//cambialo

    
    public static void Transferir(Cuenta cuentaOrigen, Cuenta cuentaDestino, double monto)
    {
        cuentaOrigen.Saldo-=monto;
        cuentaDestino.Saldo+=monto;
    }

    
    public static void Retirar(Cuenta cuentaOrigen, double monto)
    {
        cuentaOrigen.Saldo-=monto;
    }
    
    public static void Depositar(Cuenta? cuentaDestino, double monto)
    {
        cuentaDestino.Saldo+=monto;
    }

/*public static void PagarTarjeta(Cuenta cuentaOrigen, Cuenta cuentaDestino, double monto)
    {
        cuentaOrigen.Saldo-=monto;
        cuentaDestino.Saldo+=monto;
    }
    public static void PagarrPrestamo(Cuenta cuentaOrigen, Cuenta cuentaDestino, double monto)
    {
        cuentaOrigen.Saldo-=monto;
        cuentaDestino.Saldo+=monto;
    }*/

    
    public static Operaciones ConsultarBalance(Cuenta? cuentaUsuarioLogeado)
    {
        System.Console.WriteLine(cuentaUsuarioLogeado);
        operacion.NumeroCuentaUsuario=cuentaUsuarioLogeado.NumeroCuenta;
        operacion.Operacion="Consultar balance";
        operacion.Fecha=fechaActual;
        return operacion;

    }

    public static Operaciones OperacionTranferencia(Cuenta cuentaOrigen, Cuenta cuentaDestino, double monto){

        operacion.NumeroCuentaUsuario=cuentaOrigen.NumeroCuenta;
        operacion.Operacion="Transferencia";
        operacion.NumeroCuentaDestino=cuentaDestino.NumeroCuenta;
        operacion.Monto=monto;
        operacion.Fecha=fechaActual;
        return operacion;
    }
    
    public static Operaciones  OperacionDeposito(Cuenta cuentaDestino, double monto){
        operacion.Operacion="Deposito";
        operacion.NumeroCuentaDestino=cuentaDestino.NumeroCuenta;
        operacion.Monto=monto;
        operacion.Fecha=fechaActual;
        return operacion;
    }
    
    public static Operaciones OperacionRetiro(Cuenta cuentaUsuarioLogeado, double monto){
        operacion.NumeroCuentaUsuario=cuentaUsuarioLogeado.NumeroCuenta;
        operacion.Operacion="Retiro";
        operacion.Monto=monto;
        operacion.Fecha=fechaActual;
        return operacion;
    }
    
}