using Shapes;
using System;

namespace ConApp
{

    class Program
    {
        public static void writeMessage(object pub, Location e)
        {
            Console.WriteLine("{0} moved to: ({1}, {2})", pub, e.X, e.Y);
        }

        static void Main(string[] args)
        {

            Shape circle = new Circle(10, 10, 25);
            Ellipse el = new Ellipse(30, 40, 50, 20);
            IPublisher publisher = el;

            (el as IPublisher).LocationChanged += delegate (object pub, Location e) { Console.WriteLine("{0} moved to: ({1}, {2})", pub, e.X, e.Y); };
            //(el as IPublisher).LocationChanged += (pub, e) => { Console.WriteLine("{0} moved to: ({1}, {2})", pub, e.X, e.Y); };;
            //(el as IPublisher).LocationChanged += writeMessage;

            Console.WriteLine(circle);
            Console.WriteLine(publisher);
            if (publisher is Shape) { 
                (publisher as Shape).MoveTo(50, 50);
            }

            Console.WriteLine(publisher);

            Console.ReadKey();
        }
    }
}
