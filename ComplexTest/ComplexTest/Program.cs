using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplexNumb;

namespace ComplexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex t1 = new Complex(1, 1);
            Complex t2 = new Complex(2, 3), t3;
            t3 = Complex.sum(t1, t2);
            Console.WriteLine(t1.toString());
            Console.WriteLine(t2.toString());
            Console.WriteLine(t3.toString());
        }
    }
}
