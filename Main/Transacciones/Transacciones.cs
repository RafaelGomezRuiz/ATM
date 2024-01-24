public class Transacciones{
    //public string? NombreUsuario{get;set;}

    
    public static void Transferir(Cuenta cuentaOrigen, Cuenta cuentaDestino, double monto)
    {
        cuentaOrigen.Saldo-=monto;
        cuentaDestino.Saldo+=monto;
    }
    public static void Retirar(Cuenta cuentaOrigen, double monto)
    {
        cuentaOrigen.Saldo-=monto;
    }
    public static void Depositar(Cuenta cuentaOrigen, double monto)
    {
        cuentaOrigen.Saldo+=monto;
    }
    public static void ConsultarBalance(Cuenta cuentaUsuarioLogeado)
    {
        System.Console.WriteLine(@$"
        {cuentaUsuarioLogeado.Usuario.Nombre}, 
        El saldo actual de su cuenta es de:
        {cuentaUsuarioLogeado.Saldo}
        ");
    }

    // public void Retirar(Cuenta cuenta, decimal monto)
    // {
    //     // Lógica para retirar
    // }

    // public void PagarPrestamo(Cuenta cuenta, decimal monto)
    // {
    //     // Lógica para pagar préstamo
    // }

    // public void ImprimirRecibo(string usuario, int numeroCuenta, string operacion, decimal monto)
    // {
    //     // Lógica para imprimir recibo
    // }

    // public void ConsultarBalance(Cuenta cuenta)
    // {
    //     // Lógica para consultar el saldo
    // }
}