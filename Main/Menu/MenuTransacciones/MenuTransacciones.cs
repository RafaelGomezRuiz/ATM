public class MenuTransacciones{

    public static int opcion;

    public static void ShowMenuTransacciones()
    {
        while (true)
        {
            
        
        System.Console.WriteLine(@"
        Que operacion deseas realizar?
        
        1. Deposito
        2. Retiro
        3. Consultar balance
        4. Pagar prestamo
        5. Pagar Tarjeta
        6. Salir
        :
        ");

        opcion=int.Parse(Console.ReadLine()!);

        switch ((OperacionCajero)opcion)
        {  
            case OperacionCajero.Depositar:
                MenuDepositar.ShowMenuDepositar();
                break;
            case OperacionCajero.Retirar:
                MenuRetirar.ShowMenuRetirar();
                break;
            case OperacionCajero.ConsultarBalance:
                ConsultarBalance.ShowMenuConsultarBalance();
                break;
            case OperacionCajero.PagarPrestamo:
                PagarPrestamo.ShowMenuPagarPrestamo();
                break;
            case OperacionCajero.PagarTarjeta:
                MenuPagarTarjeta.ShowMenuPagarTarjeta();
                break;
            case OperacionCajero.Salir:
                    System.Console.WriteLine("Retire su tarjeta, el programa finalizado, gracias por preferirnos");
                break;
        
            default:
                System.Console.WriteLine("Haz introducido un valor incorrecto.");
                continue;
        }
        }
        
    }
    public enum OperacionCajero
        {
            Depositar,
            Retirar,
            ConsultarBalance,
            PagarPrestamo,
            PagarTarjeta,
            Salir
        }
}