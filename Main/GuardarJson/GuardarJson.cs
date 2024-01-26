using Newtonsoft.Json;



public class GuardarJson{

    public const string rutaUsuarios="usuarios.json"; //las constantes por defecto son estaticas
    public const string rutaCuenta="CuentaUsuarios.json";
    public const string rutaHistorialOperaciones="HistorialOperacion.json";

    public static List<Cuenta> cuentasActualesJson= LeerJson.LeerCuenta();

    public static List<Operaciones> HistorialJson= LeerJson.LeerHistorialOperaciones();

    public static void GuardarUsuarios(List<Usuario> usuario){
        
        //Para hacerlo de esta manera hay que importar System.Text.Json el otr ejemplo es con Newton
        //   var options = new JsonSerializerOptions { WriteIndented = true };
        //  string jsonString = JsonSerializer.Serialize(weatherForecast, options);

        //con esta linea hacemos lo mismo que haciamos en las dos lineas anteriores
        string? Json=JsonConvert.SerializeObject(usuario,Formatting.Indented);
        File.WriteAllText(rutaUsuarios,Json);
    }
    public static void GuardarCuenta(List<Cuenta> cuentas){

        string? cuentaJson=JsonConvert.SerializeObject(cuentas, Formatting.Indented);
        File.WriteAllText(rutaCuenta,cuentaJson);
    }
    
    public static void GuardarCuentaActualizada(List<Cuenta> cuentas){
        
        string? cuentaJsonActualizada=JsonConvert.SerializeObject(cuentas, Formatting.Indented);
        File.WriteAllText(rutaCuenta,cuentaJsonActualizada);
    }

    public static void ActualizarCuentasDespuesTransaccion(Cuenta cuentaUsuario){
        
                //leer cuenta tiene las cuentas dezerializadas
                cuentasActualesJson.Add(cuentaUsuario);
 
                GuardarJson.GuardarCuentaActualizada(cuentasActualesJson);
    }

    public static void GuardarHistorial(Operaciones operacion){
        HistorialJson.Add(operacion);
        string? HistorialOperaciones=JsonConvert.SerializeObject(HistorialJson,Formatting.Indented);
        File.WriteAllText(rutaHistorialOperaciones,HistorialOperaciones);
    }

    public static void RemoverCuentaJson(Cuenta cuentaUsuario){
            Cuenta? cuenta=cuentasActualesJson.FirstOrDefault(p => p.NumeroCuenta==cuentaUsuario.NumeroCuenta);
            
            cuentasActualesJson.Remove(cuenta);
    }

}