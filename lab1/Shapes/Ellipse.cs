using System;

namespace Shapes
{
    public class Ellipse : Shape
    {
        private int _radiusX;
        private int _radiusY;

        public Ellipse(int x, int y, int radiusX, int radiusY): base(x, y)
        {
            _radiusX = radiusX;
            _radiusY = radiusY;
        }

        public override void Show()
        {
            Console.WriteLine("Class: Ellipse | Location: ({0},{1}) | Radius(X/Y): ({2}, {3})", _location.X, _location.Y, _radiusX, _radiusY);
        }
    }
}
