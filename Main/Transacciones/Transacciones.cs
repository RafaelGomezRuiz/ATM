public class Transacciones{
    //public string? NombreUsuario{get;set;}
        public static Operaciones operacion= new Operaciones();

    public static DateTime fechaActual=DateTime.Now;

    
    public static void Transferir(Cuenta cuentaOrigen, Cuenta cuentaDestino, double monto)
    {
        cuentaOrigen.Saldo-=monto;
        cuentaDestino.Saldo+=monto;
    }
    public static void Retirar(Cuenta cuentaOrigen, double monto)
    {
        cuentaOrigen.Saldo-=monto;
    }
    public static void Depositar(Cuenta? cuentaOrigen, double monto)
    {
        cuentaOrigen.Saldo+=monto;
    }
    public static void ConsultarBalance(Cuenta? cuentaUsuarioLogeado)
    {
        System.Console.WriteLine(@$"
        {cuentaUsuarioLogeado.Usuario.Nombre}, 
        El saldo actual de su cuenta es de:
        {cuentaUsuarioLogeado.Saldo}
        ");
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