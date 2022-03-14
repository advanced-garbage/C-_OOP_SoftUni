using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyRealLifeExample.ProxyClasses
{
    // Real Subject class
    public class Math : IMath
    {
        public double Add(double x, double y) => x + y;
        public double Div(double x, double y) => x / y;
        public double Mul(double x, double y) => x * y;
        public double Sub(double x, double y) => x - y;
    }
}
