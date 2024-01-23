public class Transacciones{
    
    
    public static void Depositar(Cuenta cuentaOrigen, Cuenta cuentaDestino, double monto)
    {
        cuentaOrigen.Saldo-=monto;
        cuentaDestino.Saldo+=monto;

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