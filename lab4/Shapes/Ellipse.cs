using System;
using Newtonsoft.Json;

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

        public int RadiusY
        {
            get
            {
                return _radiusY;
            }

            set
            {
                _radiusY = value;
            }
        }

        public int RadiusX
        {
            get
            {
                return _radiusX;
            }

            set
            {
                _radiusX = value;
            }
        }

        public override double GetArea()
        {
            return Math.PI * _radiusX *_radiusY;
        }

        public override int CompareTo(object obj)
        {
            if (obj is Shape shape)
            {
                var area1 = GetArea();
                var area2 = shape.GetArea();
                return area1.CompareTo(area2);

            }
            throw new InvalidCastException("Can't compare Shape object with another type");
        
        }

        public override string ToString()
        {
            return string.Format("Ellipse: {0}, {1}; {2}, {3}", Location.X, Location.Y, _radiusX, _radiusY);
        }

        public string JSONSerialize()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            return JsonConvert.SerializeObject(this, settings);
        }

    }
}
