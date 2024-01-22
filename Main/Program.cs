namespace ATM;
using System.Text.Json;


class Program
{
    static void Main(string[] args)
    {
        //Codigo para guardar los usuarios
        // List<Usuario> ResgisUsuario=new List<Usuario>{
        //     new Usuario{
        //         Nombre="rafael gomez",
        //         Cedula="4022067",
        //         Correo="Rafaxxzz@gmail.com",
        //         Telefono = 806954
        //     },
        //     new Usuario{
        //         Nombre="Huasca Buryes",
        //         Cedula="4022000",
        //         Correo="Aldedilloz@gmail.com",
        //         Telefono = 806803
        //     }
        // };

        // GuardarJson.GuardarUsuarios(ResgisUsuario);

            //Este es el ejmplo de
            // string jsonString = JsonSerializer.Serialize(usuario);
            // Console.WriteLine(jsonString);
            
            List<Usuario> usuarios=LeerJson.LeerUsuario();

            List<Cuenta> CuentaUser=new List<Cuenta>();

            foreach (var cuenta1 in usuarios)
            {
               Cuenta cuentas = new Cuenta(cuenta1);
                CuentaUser.Add(cuentas);
            }
            
            GuardarJson.GuardarCuenta(CuentaUser);
    }
}
