using Area.Figures.Basic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Area.Figures
{
    public class Triangle : IPolygon
    {
        private IList<Line> _lines;

        public IList<Line> Lines
        {
            get => _lines;
            set
            {
                if (value == null || value.Count != 3)
                    throw new ArgumentException("Triangle must have 3 lines");
                _lines = value;
            }
        }

        public Triangle(IList<Line> lines)
        {
            Lines = lines;
            var dots = GetDots();
            if (dots.Distinct().Count()<3)
                throw new ArgumentException("Triangle must have 3 distinct lines");
            
            if (Lines[0].A!=Lines[2].B || Lines[0].B!=Lines[1].A || Lines[1].B!=Lines[2].A)
                throw new ArgumentException("Triangle cannot exist");
            
            double a = Lines[0].Length(),
                b = Lines[1].Length(),
                c = Lines[2].Length();
            if (a + b <= c && a + c <= b && b + c <= a)
                throw new ArgumentException("Triangle cannot exist");
        }

        public bool IsRectangular()
        {
            var dots = GetDots();
            Dot a = dots[0],
                b = dots[1],
                c = dots[2];
            double vx1 = b.X - a.X,
                vy1 = b.Y - a.X,
                vx2 = c.X - b.X,
                vy2 = c.Y - b.Y,
                vx3 = a.X - c.X,
                vy3 = a.Y - c.Y;
            return vx1 * vx2 + vy1 * vy2 == 0d || vx2 * vx3 + vy2 * vy3 == 0d || vx3 * vx1 + vy3 * vy1 == 0d;
        }
        public IList<Dot> GetDots() => new List<Dot>(3){Lines[0].A,Lines[0].B,Lines[1].B};

        public double GetArea() => Area.GetArea(this);

        public IList<Line> GetLines() => Lines;
    }
}
