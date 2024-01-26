public class MenuTransferencia{
    public static int numCuentaDestino;
    public static Cuenta? cuentaDestino;
    public static double monto;
    public static Operaciones? OperacionRealizada;

    public static void ShowMenuTransferencia()
    {
        System.Console.WriteLine("Ingresa el numero de cuenta :");
        numCuentaDestino=int.Parse(Console.ReadLine()!);
        ValidarUsuarios.ExisteCuenta(numCuentaDestino);

        if(ValidarUsuarios.ExisteCuenta(numCuentaDestino)){
            while(true)
            {
                cuentaDestino=ValidarUsuarios.BuscarCuenta(numCuentaDestino);
                System.Console.WriteLine("Ingresa el monto: ");
                monto=double.Parse(Console.ReadLine()!);
                    
                        if(monto>0){
                            if(MenuPrincipal.cuentaUsuarioLogeado.Saldo>monto){

                                GuardarJson.RemoverCuentaJson(MenuPrincipal.cuentaUsuarioLogeado);
                                GuardarJson.RemoverCuentaJson(cuentaDestino);

                                Transacciones.Transferir(MenuPrincipal.cuentaUsuarioLogeado,cuentaDestino, monto); //este metodo recibe la cuenta que se valido al iniciar sesion
                                
                                GuardarJson.ActualizarCuentasDespuesTransaccion(MenuPrincipal.cuentaUsuarioLogeado);
                                GuardarJson.ActualizarCuentasDespuesTransaccion(cuentaDestino);

                                System.Console.WriteLine("Transferencia exitosa.");

                                OperacionRealizada=Transacciones.OperacionTranferencia(MenuPrincipal.cuentaUsuarioLogeado,cuentaDestino, monto);
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
        else{
            System.Console.WriteLine("No existe cuenta con ese numero, presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}