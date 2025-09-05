using System.Reflection.Emit;
using Ejemplotrl;

namespace InformacionGeneral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            double b = 0;
            double h = 0;
            //bievenida
            Console.WriteLine("[Programa para calcular medidas de un tringulo]");
            Nuevaclass triangulo1 = new Nuevaclass(b, h);
            //ingreso de datos
            Console.WriteLine("[ingrse la base del trianguklo porfavor]");
            triangulo1.b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("[ingrse la altura del trianguklo porfavor]");
            triangulo1.h = Convert.ToDouble(Console.ReadLine());
            //menu
            int opc = 0;
            do
            {
                Console.WriteLine("[Menu de opciones]");
                Console.WriteLine("1. [Cambiar valores]");
                Console.WriteLine("2. [Mostrar perimetro]");
                Console.WriteLine("3. [Mostrar area]");
                Console.WriteLine("4. [mostrar base y altura]");
                Console.WriteLine("5. [Salir]");
                opc = int.Parse(Console.ReadLine());
                //casos
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("[ingrse la base del trianguklo porfavor]");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("[ingrse la altura del trianguklo porfavor]");
                        h = Convert.ToDouble(Console.ReadLine());
                        triangulo1.CambiarValores(b, h);
                        break;
                    case 2:
                        Console.WriteLine($"[El perimetro del triangulo es: {triangulo1.Perimetro()}]");
                        break;
                    case 3:
                        Console.WriteLine($"[El area del triangulo es: {triangulo1.Area()}]");
                        break;
                    case 4:
                        Console.WriteLine($"[La base del triangulo es: {triangulo1.b}]");
                        Console.WriteLine($"[La altura del triangulo es: {triangulo1.h}]");
                        break;
                    case 5:
                        Console.WriteLine("[Saliendo del programa...]");
                        break;
                    default:
                        Console.WriteLine("[Opcion no valida, intente de nuevo]");
                        break;
                }
            } while (opc != 5);
        }
    }
}
//para crear nuevos proyectos en visual studio usar el comando: 
// "dotnet new console -o nombredelproyecto"

//para depurar el proyecto usar comando:
// "> .NET: Generate Assets for Build and Debug"