using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConTemp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.Write("Enter the Value of Celsius: ");
            c = double.Parse(Console.ReadLine());

            f = (c * 9 / 5) + 32;
            k = c + 273.15;

            Console.WriteLine("Fahrenheit: " + f);
            Console.WriteLine("Kelvin: " + k);


        }
    }
}
