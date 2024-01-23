public class MenuTransacciones{

    public static int opcion;
    public static bool bucle=true;

    public static void ShowMenuTransacciones()
    {
         //Console.Title=$"bienvenido {MenuPrincipal.cuentaUsuarioLogeado.Nombre}"; ----Hare esto despues
        while (bucle)
        {
        System.Console.WriteLine(@"
        Que operacion deseas realizar?
        
        0. Deposito
        1. Retiro
        2. Consultar balance
        3. Pagar prestamo
        4. Pagar Tarjeta
        5. Salir
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
                bucle=false;
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