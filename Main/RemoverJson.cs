public class RemoverJson{

        public static void RemoverCuentasUsuariosJson(Usuario usuario, Cuenta cuenta){
                    //ya tengo la cuenta del ususario logeado
                    usuario.Productos.Cuentas.Remove(cuenta);
                GuardarJson.GuardarCuentaActualizada(GuardarJson.UsuariosActualesJson);
                    
            }
}