using System;
namespace Shapes
{
    public class Square : Shape
    {
        private int side;

        public Square(int x, int y, int s): base(x,y)
        {
            side = s;
        }

        public override double GetArea()
        {
            return side*side;
        }
    }
}
