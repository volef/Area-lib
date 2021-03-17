using System.Collections.Generic;

namespace Area.Figures.Basic
{
    public interface IPolygon : IFigure
    {
        public IList<Line> GetLines();
    }
}
