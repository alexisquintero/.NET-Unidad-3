using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de filas:");
            int filas = int.Parse(Console.ReadLine());  
            if(filas > 0){
                for (int i = 1; i < filas; i++)
                {
                    string estrellas = "";
                    for(int j = 0 ; j < ((2 * i) - 1); j++){
                        estrellas += "*";
                    }
                    Console.SetCursorPosition((estrellas.Length / 2), (i));
                    Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", estrellas));
                }
            }
            Console.ReadKey();
        }
    }
}
