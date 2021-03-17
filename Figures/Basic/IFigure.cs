using System.Collections.Generic;

namespace Area.Figures.Basic
{
    public interface IFigure
    {
        public IList<Dot> GetDots();
        public double GetArea();
    }
}