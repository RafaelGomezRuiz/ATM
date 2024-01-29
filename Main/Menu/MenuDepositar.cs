public class MenuDepositar{
 
    
    public static void ShowMenuDepositar()
    {   
        System.Console.WriteLine("Ingresa el numero de cuenta :");
        MenuTransferencia.numCuentaDestino=int.Parse(Console.ReadLine()!);
        while(true)
            {   //hayq que validar que la cuenta se encuentre
                
                MenuTransferencia.usuarioDestino=ValidarUsuarios.BuscarUsuario(MenuTransferencia.numCuentaDestino);
                MenuTransferencia.cuentaDestino=ValidarUsuarios.BuscarCuenta(MenuTransferencia.numCuentaDestino);

                if(MenuTransferencia.usuarioDestino !=null && MenuTransferencia.cuentaDestino !=null){
                    System.Console.WriteLine("Ingresa el monto: ");
                    MenuTransferencia.monto=double.Parse(Console.ReadLine()!);
                    
                        if(MenuTransferencia.monto>0){
                                
                                RemoverJson.RemoverCuentasUsuariosJson(MenuTransferencia.usuarioDestino,MenuTransferencia.cuentaDestino);

                                Transacciones.Depositar(MenuTransferencia.cuentaDestino, MenuTransferencia.monto); //este metodo recibe la cuenta que se valido al iniciar sesion
                                
                                ActualizarJson.ActualizarCuentasDespuesTransaccion(MenuTransferencia.usuarioDestino,MenuTransferencia.cuentaDestino);

                                System.Console.WriteLine("Deposito exitosa.");

                                MenuTransferencia.OperacionRealizada=Transacciones.OperacionDeposito(MenuTransferencia.cuentaDestino, MenuTransferencia.monto);
                                
                                GuardarJson.GuardarHistorial(MenuTransferencia.OperacionRealizada);
                                System.Console.WriteLine("¿Desea un recibo? (1.Sí/2.No): ");
                                int respuestaRecibo = int.Parse(Console.ReadLine()!);

                                if (respuestaRecibo == 1)
                                {
                                    Recibo.ImprimirReciboDeposito(MenuTransferencia.cuentaDestino, MenuTransferencia.monto);
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
                            System.Console.WriteLine("No puedes introducir un monto menor o igal a 0.");
                            continue;
                        }
                }
                else{
                    System.Console.WriteLine("No existe cuenta con ese numero");
                    break;
                }
            }
            
        }
}