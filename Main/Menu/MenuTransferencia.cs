public class MenuTransferencia{
    public static int numCuentaDestino;
    public static Cuenta? cuentaDestino;
    public static double monto;
    public static Operaciones? OperacionRealizada;

    public static void ShowMenuTransferencia()
    {
        System.Console.WriteLine("Ingresa el numero de cuenta :");
        numCuentaDestino=int.Parse(Console.ReadLine()!);
        while(true)
            {   //hayq que validar que la cuenta se encuentre
                
                ValidarUsuarios.usuarioDestino=ValidarUsuarios.BuscarUsuario(numCuentaDestino);
                cuentaDestino=ValidarUsuarios.BuscarCuenta(numCuentaDestino);

                if(ValidarUsuarios.usuarioDestino !=null && cuentaDestino !=null){
                    System.Console.WriteLine("Ingresa el monto: ");
                    monto=double.Parse(Console.ReadLine()!);
                    
                        if(monto>0){
                            if(MenuPrincipal.cuentaUsuarioLogeado.Saldo>monto){
                                System.Console.WriteLine(MenuPrincipal.UsuarioLogeado);
                                System.Console.WriteLine(ValidarUsuarios.usuarioDestino);
                                
                                RemoverJson.RemoverCuentasUsuariosJson(MenuPrincipal.UsuarioLogeado,MenuPrincipal.cuentaUsuarioLogeado);
                                RemoverJson.RemoverCuentasUsuariosJson(ValidarUsuarios.usuarioDestino,cuentaDestino);

                                Transacciones.Transferir(MenuPrincipal.cuentaUsuarioLogeado,cuentaDestino, monto); //este metodo recibe la cuenta que se valido al iniciar sesion
                                
                                //ActualizarJson.ActualizarCuentasDespuesTransaccion(ValidarUsuarios.UsuarioLogeado,MenuPrincipal.cuentaUsuarioLogeado);
                                //ActualizarJson.ActualizarCuentasDespuesTransaccion(ValidarUsuarios.usuarioDestino,ValidarUsuarios.CuentaUsuarioDestino);

                                System.Console.WriteLine("Transferencia exitosa.");

                                //OperacionRealizada=Transacciones.OperacionTranferencia(MenuPrincipal.cuentaUsuarioLogeado,cuentaDestino, monto);
                                GuardarJson.GuardarHistorial(OperacionRealizada);
                                System.Console.WriteLine("¿Desea un recibo? (1.Sí/2.No): ");
                                int respuestaRecibo = int.Parse(Console.ReadLine()!);

                                if (respuestaRecibo == 1)
                                {
                                    Recibo.ImprimirReciboTransferencia(MenuPrincipal.cuentaUsuarioLogeado,cuentaDestino, MenuTransferencia.monto);
                                }
                                else if(respuestaRecibo == 2){
                                    System.Console.WriteLine("Gracias por preferirnos");
                                }
                                else{
                                    System.Console.WriteLine("Valor incorrecto");
                                }
                                break;
                                
                            }
                            else{
                                System.Console.WriteLine("No tienes saldo suficiente");
                                break;
                            }
                        }
                        else{
                            System.Console.WriteLine("No puedes introducir un monto menor o igal a 0.");
                            continue;
                        }
                }
            }
            
        }
        
    }
