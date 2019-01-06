using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compito
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            //a corrisponde al valore massimo che può essere inserito
            Console.WriteLine(a);
            //si somma 1 ad "a" e si ottiene il valore minimo
            if (a < int.MaxValue)
            {
                Console.WriteLine(a + 1);
            }
            // si dà a "b" il valore di 128 e a "c" la sua negaione, poi si trasformano in binario
            int b = -128;
            int c = -b;
            Console.WriteLine(Convert.ToString(b, 2));
            Console.WriteLine(Convert.ToString(c, 2));
            int value = 31;
            int somma = value;
            value = ~value + 1;  //NOT
            //value = value + 1;
            somma = somma + value;
            Console.WriteLine($"{value} e {somma}");
            long number = 55555;
            Console.WriteLine(Convert.ToString(number, 2));
            short number1 = (short)number;
            Console.WriteLine(number1);


            Console.ReadLine();
        }
    }
}
