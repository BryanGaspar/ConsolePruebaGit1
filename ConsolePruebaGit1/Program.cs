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
            Console.WriteLine("La suma de 10 + 20 es {0}", funcionSuma(10, 20));
            Console.ReadKey();
        }
        public static int funcionSuma(int a, int b)
        {
            return (a + b);
        }
    }
}
