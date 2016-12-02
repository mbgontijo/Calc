using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitCalc
{
    public class Calc
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            int r = c.Soma(4, 5);

            Console.WriteLine("Resultado: " + r);
            Console.ReadKey();
        }

        public int Soma(int a, int b)
        {
            return a + b;
        }
    }
}
