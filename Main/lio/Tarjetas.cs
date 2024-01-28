public class Tarjetas{
    public int autoIncrement=0;
    public int NumeroTarjeta { get; set; }
    public DateTime FechaExpiracion { get; set; }
    public bool EstadoTarjeta {get;set;}
    public double SaldoDeuda {get;set;}

    public Tarjetas( double saldoDeuda)
    {
        NumeroTarjeta = autoIncrement++;
        FechaExpiracion = DateTime.Now;
        EstadoTarjeta = true;
        SaldoDeuda = saldoDeuda;
    }

}