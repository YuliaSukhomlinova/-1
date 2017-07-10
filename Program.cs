using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            double pi=3.14;
            double r,a,s,d,p,Sk;
           Console.WriteLine("Vvedite ploshad kruga:\n");
           s = Convert.ToDouble(Console.ReadLine());
            r=Math.Sqrt(s/pi);
            d = 2 * r;
            a = d / Math.Sqrt(2);
            p = a * 4;
            Sk = a * a;
            Console.WriteLine("Perimetr: {0}",Convert.ToString(p));
            Console.WriteLine("Ploshad: {0}", Convert.ToString(Sk));
            Console.ReadKey();
        }
    }
}
