public class MenuPrincipal
{
    static public int NumCuentaLogeado;
    static public int pin;
    public static  bool buclePin=true;
    public static Cuenta? cuentaUsuarioLogeado;
    public static Usuario? UsuarioLogeado;

    public static void ShowMenuCredenciales()
    {
        while(true){
        Console.WriteLine("Ingrese su numero de cuenta: ");
            NumCuentaLogeado=int.Parse(Console.ReadLine()!);
            
                UsuarioLogeado=ValidarUsuarios.BuscarUsuario(NumCuentaLogeado);
                cuentaUsuarioLogeado=ValidarUsuarios.BuscarCuenta(NumCuentaLogeado);
                if(cuentaUsuarioLogeado != null ){
                
                if( (ValidarUsuarios.CuentaHabilitada(cuentaUsuarioLogeado))==false){
                                    System.Console.WriteLine("Su cuenta esta inhabilitada");

                    break;
                }

                // if(cuentaUsuarioLogeado!=null && ValidarUsuarios.CuentaHabilitada(cuentaUsuarioLogeado)==true )
                //no importa que tenga el metodo anterior para verificar si la cuenta existe el sistema entiende que en este punto 
                //cuando se busca la cuenta 
                        while(buclePin==true){
                            Console.WriteLine("Ingrese su PIN (4 dígitos):");
                            pin = int.Parse(Console.ReadLine()!);
                            ValidarUsuarios.Credenciales(cuentaUsuarioLogeado,pin);
                            }
                            break;
                    
                        }
                   }
            //        else if (cuentaUsuarioLogeado != null && ValidarUsuarios.CuentaHabilitada(cuentaUsuarioLogeado)==false )
            // {
            //     System.Console.WriteLine("Su cuenta esta inhabilitada");
            //     break;
            // } de esta forma tenia un bug

        }     
}





