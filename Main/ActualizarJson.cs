public class ActualizarJson{
    
    public static void ActualizarCuentasDespuesTransaccion(Usuario usuario,Cuenta cuentaUsuario) {//recuerda que esta es la cuenta del usuario logeado    
                
                   usuario.Productos.Cuentas.Add(cuentaUsuario);
            GuardarJson.GuardarCuentaActualizada(GuardarJson.UsuariosActualesJson);
    }
}