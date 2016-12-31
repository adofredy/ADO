using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Task; 

namespace presentacion6
{ 
  class Program
  { 
      static void Main(string[] args)
      {
      ClientesVentas Cliente;
      Cliente.IdCliente = 123;
      Cliente.Apellidos = "Perez Piyo";
      Cliente.Nombres ="Juanito";
      Cliente.RFC="HEM";
      Cliente.Direccion="HEM";
      Cliente.Colonia="la fe de C";
      Cliente.Municipio="Chepqew";
      Console.EsCredito = true;  
      Console.WriteLine(Cliente.Apellidos + " " + Cliente.Nombres);
      Console.WriteLine(Cliente.Direccion + " " + Cliente.Colonia+" "+ ClienteMunicipio);
      Console.WriteLine(Cliente.RFC);
        
      if (Cliente.EsCredito)
          Console.WriteLine("El Cliente tiene Credito ");
       else
          Console.WriteLine("El Cliente no tiene Credito ");
       Console.ReadKey();
      }
  }
  
} 
