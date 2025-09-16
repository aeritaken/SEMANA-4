using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA4_C_
{
    internal class EJERCICIO1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 18);
            {

                Console.Write("menor de edad");

            }
            else
            {
                if (edad <= 64)
                {
                    Console.WriteLine("Adulto!");
                }
                else
                {
                    Console.WriteLine("Adulto mayor");
                }

            }

        }
    }
}
