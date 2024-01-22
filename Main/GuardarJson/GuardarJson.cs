using Newtonsoft.Json;



public class GuardarJson{

    const string? rutaArchivo="usuarios.json";
    const string rutaCuenta="CuentaUsuarios.json";
    public static void GuardarUsuarios(List<Usuario> usuario){
        
        //Para hacerlo de esta manera hay que importar System.Text.Json el otr ejemplo es con Newton
        //   var options = new JsonSerializerOptions { WriteIndented = true };
        //  string jsonString = JsonSerializer.Serialize(weatherForecast, options);

        //con esta linea hacemos lo mismo que haciamos en las dos lineas anteriores
        string? Json=JsonConvert.SerializeObject(usuario,Formatting.Indented);
        File.WriteAllText(rutaArchivo,Json);
    }
    public static void GuardarCuenta(List<Cuenta> cuentas){

        string? cuentaJson=JsonConvert.SerializeObject(cuentas, Formatting.Indented);
        File.WriteAllText(rutaCuenta,cuentaJson);
    }
}