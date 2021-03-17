using System;
using System.Collections.Generic;
using Area.Figures.Basic;

namespace Area.Figures
{
    public class Circle : IFigure
    {
        private double _radius;

        public double Radius
        {
            get => _radius;
            set => _radius = value >= 0d ? value : throw new ArgumentException("Radius cannot be less zero");
        }
        
        public Dot Center { get; set; }

        public Circle(Dot center, double radius)
        {
            Radius = radius;
            Center = center;
        }
        
        public Circle(double x,double y, double radius) : this(new Dot(x,y),radius)
        {
        }

        public IList<Dot> GetDots() => new List<Dot>{Center};

        public double GetArea() => Area.GetArea(this);
    }
}
