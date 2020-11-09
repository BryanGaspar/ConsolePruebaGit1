using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePruebaGit1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World con c#");

            Console.WriteLine("Probando la funcion");
            int suma = funcionSuma(10, 20);
            Console.WriteLine("Resultado funcion = {0}", suma);
            Console.ReadKey();
        }

        //Funcion suma
        public static int funcionSuma(int a, int b)
        {
            return (a * 10 + b * 100);
        
        }
    }
}
