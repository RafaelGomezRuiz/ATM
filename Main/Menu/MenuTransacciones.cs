public class MenuTransacciones{

    public static int opcion;
    public static bool bucle=true;

    public static void ShowMenuTransacciones()
    {
       /* while (bucle)
        {
        System.Console.WriteLine(@"
        Que operacion deseas realizar?
        
        0. Transferencia
        1. Retiro
        2. Deposito
        3. Consultar balance
        4. Salir
        :
        ");

        opcion=int.Parse(Console.ReadLine()!);

        switch ((OperacionCajero?)opcion)
        {  
            case OperacionCajero.Transferencia:
                MenuTransferencia.ShowMenuTransferencia();
                bucle=false;
                break;
            case OperacionCajero.Retirar:
                MenuRetirar.ShowMenuRetirar();
                bucle=false;
                break;
            case OperacionCajero.Depositar:
                MenuDepositar.ShowMenuDepositar();
                bucle=false;
                break;
            case OperacionCajero.ConsultarBalance:
                Transacciones.ConsultarBalance(MenuPrincipal.cuentaUsuarioLogeado);
                bucle=false;
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
            Transferencia,
            Retirar,
            Depositar,
            ConsultarBalance,
            Salir
        }*/
}