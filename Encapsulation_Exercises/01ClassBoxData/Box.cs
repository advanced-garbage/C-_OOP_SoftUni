using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length
        {
            get { return length; }
            set
            {
                try
                {
                    if (value > 0)
                        length = value;
                    else
                        throw new ArgumentException();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Length cannot be zero or negative.");
                    Environment.Exit(0);
                }
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                try
                {
                    if (value > 0)
                        width = value;
                    else
                        throw new ArgumentException();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Width cannot be zero or negative.");
                    Environment.Exit(0);
                }
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                try
                {
                    if (value > 0)
                        height = value;
                    else
                        throw new ArgumentException();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Height cannot be zero or negative.");
                    Environment.Exit(0);
                }
            }
        }

        public Box(double l, double w, double h)
        {
            Length = l;
            Width = w;
            Height = h;
        }

        public double SurfaceArea() => (2 * Length * Width) + (2 * Height * Width) + (2 * Length * Height);

        public double Volume() => Length * Width * Height;

        public double LateralSurfaceArea() => (2 * Length * Height) + (2 * Width * Height);

        public override string ToString()
        {
            return $"Surface Area - {SurfaceArea():f2}\nLateral Surface Area - {LateralSurfaceArea():f2}\nVolume - {Volume():f2}";
        }

    }
}
