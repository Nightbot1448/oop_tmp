using Shapes;

namespace ConnApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Ellipse ellipse = new Ellipse(10, 10, 120, 50);
            Circle circle = new Circle(20, 20, 70);

            ellipse.Show();
            circle.Show();
        }
    }
}
