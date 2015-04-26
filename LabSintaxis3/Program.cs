using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arreglo = new string[5];
            int cantIteraciones = 5;
            Console.WriteLine("Ingrese valores");
            for (int i = 0; i < cantIteraciones; i++)
            {
                arreglo[i] = Console.ReadLine();
            }
            for (int j = cantIteraciones-1; -1 < j; j--)
            {
                Console.WriteLine(arreglo[j]);
            }
            Console.ReadKey();
        }

    }
}
