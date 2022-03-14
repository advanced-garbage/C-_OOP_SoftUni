using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyRealLifeExample.ProxyClasses
{
    // Interface for the Real Subject class and the Proxy class
    public interface IMath
    {
        public double Add(double x, double y);
        public double Sub(double x, double y);
        public double Mul(double x, double y);
        public double Div(double x, double y);
    }
}
