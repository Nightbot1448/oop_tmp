using System;

namespace Shapes
{
    public class Circle : Shape
    {
        private int _radius;

        public Circle(int x, int y, int radius) : base(x, y)
        {
            _radius = radius;
        }

        public override void Show()
        {
            Console.WriteLine("Class: Circle | Location: ({0},{1}) | Radius: {2}", _location.X, _location.Y, _radius);
        }
    }
}
