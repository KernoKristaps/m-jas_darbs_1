using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mājas_darbs_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rezultāts = Aprēķins();
            Console.WriteLine("c = " + rezultāts);
            Console.ReadLine();
            int a = 5;
            int b = 6;

            int c = a + b;
            a = 5;
            b = 6;
            c = a + b;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.ReadLine();
        }
        static int Aprēķins() //funkcija, kas atgriež vērtību
        {
            int a = 5;
            int b = 6;

            int c = a + b;

            return c;
        }
    }
}
