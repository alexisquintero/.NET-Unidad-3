using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int tope, cont = 1;
            Console.WriteLine("Ingrese tope numeros primos y gemelos.. si, a la vez!");
            tope = int.Parse(Console.ReadLine());
            for (int i = 3; i < tope; i++)
            {
                if (EsPrimo(i))
                {
                    if (EsPrimo(i + 2))
                    {
                        Console.WriteLine("El par número: " + cont + " es " + i + " y " + (i + 2));
                        cont += 1;
                    }
                }
            
            }
            Console.ReadKey();
        }

        public static bool EsPrimo(int nro)
        {
            for (int i = 2; i < nro; i++)
            {
                if (nro % i == 0)
                {
                    return false;
                }
            }
                return true;
        }
    }
}
