using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=1,c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for(int i=0; i<20; i++){
                c=a+b;
                Console.WriteLine(c.ToString());
                a = c + b;
                Console.WriteLine(a.ToString());
                b = a + c;
                Console.WriteLine(b.ToString());
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
