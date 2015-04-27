using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Los números pares del 1 al 100 son:");
            for (int i = 1; i < 101; i++)
            {
                if ((i%2) == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
