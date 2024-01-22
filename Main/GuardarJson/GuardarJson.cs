using Newtonsoft.Json;



public class GuardarJson{

    const string? rutaArchivo="usuarios.json";

    public static void GuardarUsuarios(List<Usuario> usuario){
        
        //  var options = new JsonSerializerOptions { WriteIndented = true };
        // string jsonString = JsonSerializer.Serialize(weatherForecast, options);

        //con esta linea hacemos lo mismo que haciamos en las dos lineas anteriores
        string? Json=JsonConvert.SerializeObject(usuario,Formatting.Indented);
        File.WriteAllText(rutaArchivo,Json);
    }
}