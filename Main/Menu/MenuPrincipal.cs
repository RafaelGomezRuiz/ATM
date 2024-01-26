public class MenuPrincipal
{
    static public int NumCuenta;
    static public int pin;
    public static  bool buclePin=true;
    public static Cuenta cuentaUsuarioLogeado;

    public static void ShowMenuCredenciales()
    {
        while(true){
        Console.WriteLine("Ingrese su numero de cuenta: ");
            NumCuenta=int.Parse(Console.ReadLine()!);
            

            if (ValidarUsuarios.ExisteCuenta(NumCuenta)==true )
            { 
                cuentaUsuarioLogeado=ValidarUsuarios.BuscarCuenta(NumCuenta);
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
            
            else{
                System.Console.WriteLine("No existe una cuenta con ese numero, intentalo de nuevo: "); //Recuerda cambiar esto que no tiene sentido
                continue;
            }
        }     
    }
}




