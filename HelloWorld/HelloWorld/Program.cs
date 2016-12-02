using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        private static DateTime dt;

        static void Main(string[] args)
        {
            dt = DateTime.Now;
            Console.WriteLine("Hello, mundo Gif!!");
            Console.WriteLine("Ontem : " + GetTomorrow());
            Console.WriteLine("Hoje é " + dt.ToString("dd/MM/yyyy hh:mm:ss"));
            Console.WriteLine("Dias no mes de fevereiro: " + DateTime.DaysInMonth(2016, 2));
            Console.WriteLine("Dias no mes de dezembro: " + DateTime.DaysInMonth(2016, 12));
            Console.ReadKey();
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(-1);
        }
    }
}
