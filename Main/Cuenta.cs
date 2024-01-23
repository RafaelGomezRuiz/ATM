public class Cuenta{
    public static int autoIncremento=0;

    public int NumeroCuenta { get; set; }
    public Usuario Usuario;
    public int Pin { get; set; }
    public double Saldo { get; set; }
    public string? TipoCuenta { get; set; }
    public bool EstadoCuenta {get;set;}
    public DateTime FechaCreacion;

    public Cuenta()
    {
        
    }

    public Cuenta(Usuario usuario)
    {
        NumeroCuenta=autoIncremento++;
        Usuario = usuario;
        System.Console.WriteLine("introduce un pin de 4 digitos");
        Pin = int.Parse(Console.ReadLine()!);
        System.Console.WriteLine("Saldo inicial:");
        Saldo = double.Parse(Console.ReadLine()!);
        System.Console.WriteLine("Tipo de cuenta: ");
        TipoCuenta = Console.ReadLine()!;
        EstadoCuenta=true;
        FechaCreacion=DateTime.Now;
        
    }

    

}