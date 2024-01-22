using Newtonsoft.Json;

public class LeerJson{

    public static List<Usuario> LeerUsuario(){

        string? path = "usuarios.json";
        string? JsonUsuario = File.ReadAllText(path);
        List<Usuario> usuario = JsonConvert.DeserializeObject<List<Usuario>>(JsonUsuario);
        
        return usuario;
    }

    public static List<Cuenta> LeerCuenta(){
       string? path="CuentaUsuarios.json";
       string? JsonCuenta=File.ReadAllText(path); 
       List<Cuenta> cuentas=JsonConvert.DeserializeObject<List<Cuenta>>(JsonCuenta);
       return cuentas;
    }
}