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
            int a, b = 0;
            Console.WriteLine("Ingrese tope numeros primos y gemelos.. si, a la vez!");
            a = int.Parse(Console.ReadLine());
            for (int i=2; i<(a+1);i++)
            {
                for (int j = (i-1); 2 < j; j--)
                {
                    if ((i - b) = 2)
                    {
                        if (i % j == 0)
                        {
                            b = i;
                        }
                    }
                    
                }
            }
        }
    }
}
