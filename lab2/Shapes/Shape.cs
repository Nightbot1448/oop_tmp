using System;

namespace Shapes
{
    public abstract class Shape : IComparable
    {
        protected Location _location;

        protected Shape(int x, int y)
        {
            _location = new Location { X = x, Y = y };
        }

        public void MoveTo(int x, int y)
        {
            _location.X = x;
            _location.Y = y;
        }

        public abstract double GetArea();

        public int CompareTo(object obj)
        {
            if (obj is Shape shape)
            {
                double area_1 = GetArea();
                double area_2 = shape.GetArea();
                return area_1.CompareTo(area_2);
            }
            throw new InvalidCastException("Can't compare Shape object with another type");
        }

        public override string ToString()
        {
            return string.Format("Object: {0}; area: {1}", GetType().Name, GetArea());
        }
    }
}
