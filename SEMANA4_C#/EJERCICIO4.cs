using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA4_C_
{
    internal class EJERCICIO4
    {
        static void Main(string[] args)
        {
            Console.Write("Bienvenidos al cálculo de áreas\n");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Rectángulo");
            Console.WriteLine("3. Triángulo");
            Console.WriteLine("4. Círculo");
            Console.Write("\nIngrese una opción: ");
            int opción = int.Parse(Console.ReadLine());

            switch (opción)
            {
                case 1: Console.WriteLine("\nIngrese lado: ");
                    int lado = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nÁrea: " + (lado * lado));
                    break;
                case 2:
                    Console.WriteLine("\nIngrese la base: ");
                    int bse = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura: ");
                    int alt = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nÁrea: " + (bse * alt));
                    break;
                case 3:
                    Console.WriteLine("\nIngrese la base: ");
                    int bse2 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura: ");
                    int alt2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nÁrea: " + (bse2 * alt2)/2);
                    break;
                case 4:
                    Console.WriteLine("\nIngrese el radio: ");
                    double radio = double.Parse(Console.ReadLine());
                    Console.WriteLine("\nÁrea: " + Math.PI * (radio*radio),2);
                    break;
                default:
                    Console.WriteLine("\nOpción Incorrecta");
                    break;
            }
        }
    }
}
