public class MenuRetirar{
 
    public static void ShowMenuRetirar()
    {
        while(true)
            {
                System.Console.WriteLine("Ingresa el monto: ");
                MenuTransferencia.monto=double.Parse(Console.ReadLine()!);
                        if(MenuTransferencia.monto>0){
                            if(MenuPrincipal.cuentaUsuarioLogeado.Saldo>MenuTransferencia.monto){

                                GuardarJson.RemoverCuentaJson(MenuPrincipal.cuentaUsuarioLogeado);

                                Transacciones.Retirar(MenuPrincipal.cuentaUsuarioLogeado, MenuTransferencia.monto); //este metodo recibe la cuenta que se valido al iniciar sesion
                                
                                GuardarJson.ActualizarCuentasDespuesTransaccion(MenuPrincipal.cuentaUsuarioLogeado);
                                System.Console.WriteLine("Retiro exitoso.");
                                MenuTransferencia.OperacionRealizada=Transacciones.OperacionRetiro(MenuPrincipal.cuentaUsuarioLogeado, MenuTransferencia.monto);
                                GuardarJson.GuardarHistorial(MenuTransferencia.OperacionRealizada);
                                
                                break;
                                
                            }
                            else{
                                System.Console.WriteLine("No tienes saldo suficiente");
                                break;
                            }
                        }
                        else{
                            System.Console.WriteLine("No puedes introducir un monto menor o igual a 0.");
                            continue;
                        }
            }
    }
}