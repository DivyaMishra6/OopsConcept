using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public abstract class AreaFind
    {
        public double Width, Height, Radius;
        public const double Pi = 3.14;

        public abstract double GetArea();
    }

    public class Rectangle : AreaFind
    {
        public Rectangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }

    }

    public class Circle : AreaFind
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public override double GetArea()
        {
            return Pi * Radius * Radius;
        }
    }
}
