public class Cuenta{
    public static int autoIncremento=0;
    
    public DateTime FechaCreacion;
    public int NumeroCuenta { get; set; }
    public int Pin { get; set; }
    public double Saldo { get; set; }
    public string? TipoCuenta { get; set; }
    public bool EstadoCuenta {get;set;}
    
public override string ToString()
    {
        return $"Número de Cuenta: {NumeroCuenta}, Tipo de Cuenta: {TipoCuenta}, Saldo: {Saldo:C}, Estado de Cuenta: {(EstadoCuenta ? "Activa" : "Inactiva")}";
    }

    
}