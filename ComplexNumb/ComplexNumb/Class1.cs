using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumb
{
    public class Complex
    {
        private double re, im;

        public Complex(double r, double i)
        {
            re = r;
            im = i;
        }

        public static Complex sum(Complex left, Complex right)
        {
            return new Complex(left.re + right.re, left.im + right.im);
        }

        public string toString()
        {
            return (re.ToString() + "   " + im.ToString() + "i");
        }
    }
}
