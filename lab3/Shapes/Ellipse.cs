using System;

namespace Shapes
{
    public class Ellipse : Shape, IPublisher
    {
        private int _radiusX;
        private int _radiusY;

        public event EventHandler<Location> LocationChanged;

        public Ellipse(int x, int y, int radiusX, int radiusY) : base (x, y)
        {
            _radiusX = radiusX;
            _radiusY = radiusY;
        }

        public override void MoveTo(int x, int y)
        {
            base.MoveTo(x, y);
            LocationChanged?.Invoke(this, _location);
        }

        public override double GetArea()
        {
            return Math.PI * _radiusX *_radiusY;
        }

        public override string ToString()
        {
            return string.Format("Ellipse: ({0}, {1} ; {2} {3})", _location.X, _location.Y, _radiusX, _radiusY);
        }

    }
}
