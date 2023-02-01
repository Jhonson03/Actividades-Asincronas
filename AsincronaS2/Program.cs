using AsincronaS2.Entidades;
using AsincronaS2.Negocio;

Datos dat = new Datos();
ClsDatos clsDatos = new ClsDatos();

Console.WriteLine(@"►►►►►►►►►►►►►►►►►►►►►►►►►►►►
Número mayor de dos números
►►►►►►►►►►►►►►►►►►►►►►►►►►►►

Presione enter para continuar");
Console.ReadLine();

Console.WriteLine("Ingrese el primer número");
dat.dat1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nIngrese el Segundo número");
dat.dat2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(clsDatos.Comparacion(dat));