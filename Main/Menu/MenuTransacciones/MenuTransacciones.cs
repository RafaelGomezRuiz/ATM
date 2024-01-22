public class MenuTransacciones{
    public static void MenuTransacciones()
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

        opcion=int.Parse(Console.ReadLine());

        switch ((OperacionCajero)opcion)
        {  
            case OperacionCajero.Depositar:
                MenuDepositar.MenuDepositar();
                break;
            case OperacionCajero.Retirar:
                MenuRetirar.MenuRetirar();
                break;
            case OperacionCajero.ConsultarBalance:
                MenuConsultarBalance.MenuConsultarBalance();
                break;
            case OperacionCajero.PagarPrestamo:
                MenuPagarPrestamo.MenuPagarPrestamo();
                break;
            case OperacionCajero.PagarTarjeta:
                MenuPagarTarjeta.MenuPagarTarjeta();
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