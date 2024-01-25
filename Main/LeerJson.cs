using Newtonsoft.Json;

public class LeerJson{

    public static List<Usuario> LeerUsuario(){

        string? JsonUsuario = File.ReadAllText(GuardarJson.rutaUsuarios);
        List<Usuario> usuario = JsonConvert.DeserializeObject<List<Usuario>>(JsonUsuario);
        
        return usuario;
    }

    public static List<Cuenta> LeerCuenta(){

       string? JsonCuenta=File.ReadAllText(GuardarJson.rutaCuenta); 
       List<Cuenta> cuentas=JsonConvert.DeserializeObject<List<Cuenta>>(JsonCuenta);
       return cuentas;
    }

    public static List<Operaciones> LeerHistorialOperaciones()
    {
        if (File.Exists(GuardarJson.rutaHistorialOperaciones)){

            string? JsonHistorial=File.ReadAllText(GuardarJson.rutaHistorialOperaciones);
            List<Operaciones> operacion=JsonConvert.DeserializeObject<List<Operaciones>>(JsonHistorial);
                return operacion;
            }
        else{    
   
                return new List<Operaciones>();
            }
    }
}