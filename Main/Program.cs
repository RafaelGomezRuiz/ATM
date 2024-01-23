namespace ATM;
using System.Text.Json;


class Program
{
    static void Main(string[] args)
    {   
        //MenuPrincipal.ShowMenuCredenciales();
        Usuario.GuardarUsuarios();

        GuardarJson.GuardarUsuarios(Usuario.GuardarUsuarios());
        
        GuardarJson.GuardarCuenta(Cuenta.GuardarCuenta());
        //    // Este es el ejmplo de
        //     //string jsonString = JsonSerializer.Serialize(usuario);
        //    // Console.WriteLine(jsonString);
            
            
            
            
    }
}
