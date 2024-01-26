public class Recibo
{
    public static void ImprimirReciboRetiro(Cuenta cuenta, double monto)
    {
        Console.WriteLine("Recibo de Retiro");
        Console.WriteLine($"Cuenta: {cuenta.NumeroCuenta}");
        Console.WriteLine($"Monto Retirado: {monto}");
        Console.WriteLine($"Saldo Actual: {cuenta.Saldo}");
        Console.WriteLine("¡Gracias por usar nuestro servicio!");
    }

    public static void ImprimirReciboTransferencia(Cuenta cuentaOrigen, Cuenta cuentaDestino, double monto)
    {
        Console.WriteLine("Recibo de Transferencia");
        Console.WriteLine($"Cuenta Origen: {cuentaOrigen.NumeroCuenta}");
        Console.WriteLine($"Cuenta Destino: {cuentaDestino.NumeroCuenta}");
        Console.WriteLine($"Monto Transferido: {monto}");
        Console.WriteLine($"Saldo Actual en Cuenta Origen: {cuentaOrigen.Saldo}");
        Console.WriteLine("¡Gracias por usar nuestro servicio!");
    }

    public static void ImprimirReciboDeposito(Cuenta cuenta, double monto)
    {
        Console.WriteLine("Recibo de Depósito");
        Console.WriteLine($"Cuenta: {cuenta.NumeroCuenta}");
        Console.WriteLine($"Monto Depositado: {monto}");
        Console.WriteLine($"Saldo Actual: {cuenta.Saldo}");
        Console.WriteLine("¡Gracias por usar nuestro servicio!");
    }
}