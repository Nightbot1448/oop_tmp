using System;

namespace Shapes
{
    public class Ellipse : Shape
    {
        private int _radiusX;
        private int _radiusY;

        public Ellipse(int x, int y, int radiusX, int radiusY) : base (x, y)
        {
            _radiusX = radiusX;
            _radiusY = radiusY;
        }

        public override double GetArea()
        {
            return Math.PI * _radiusX *_radiusY;
        }

    }
}
