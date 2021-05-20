using System;
using System.Collections.Generic;
using System.Linq;

using Shapes;
using ConApp.Factories;

namespace ConApp
{
    class Program
    {
        private const int SHAPE_COUNT = 5;

        private static Random _random = new Random();


        static void CreateShapes(ref ICollection<Shape> shapes)
        {
            for (int i = 0; i < SHAPE_COUNT; i++)
            {
                int x = _random.Next();
                int y = _random.Next();

                bool flag = _random.Next() % 2 == 0;
                if (flag)
                    shapes.Add(new Ellipse(x, y, _random.Next() % 10, _random.Next() % 10));
                else
                    shapes.Add(new Circle(x, y, _random.Next() % 10));
            }
        }

        static void CreateShapesByFactory(ref ICollection<Shape> shapes)
        {
            var factories = new List<ShapeFactory>(new ShapeFactory[]
                {
                    new EllipseFactory(),
                    new CircleFactory(),
                    new SquareFactory()
                });
            for (int i = 0; i < SHAPE_COUNT; i++)
            {
                int factoryIdx = _random.Next() % factories.Count;
                var factory = factories[factoryIdx];

                int x = _random.Next();
                int y = _random.Next();
                Shape shape = factory.CreateShape(x, y);
                if (shapes is SortedSet<Shape>)
                    Console.WriteLine(shape);
                shapes.Add(shape);
            }
            Console.WriteLine("Count of figures: {0}", shapes.Count);
        }

        static void Main(string[] args)
        {
            ICollection<Shape> shapes = new List<Shape>();
            //CreateShapes(ref shapes);
            CreateShapesByFactory(ref shapes);

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
            Console.WriteLine();

            var shapes1 = from shape in shapes where shape.GetArea() < 20 select shape;
            Console.WriteLine("Shapes1:");
            foreach (var shape in shapes1)
            {
                Console.WriteLine(shape);
            }
            Console.WriteLine();

            Console.WriteLine("Shapes2:");
            var shapes2 = shapes.Where(x => x.GetArea() < 20);
            foreach(var shape in shapes2)
            {
                Console.WriteLine(shape);
            }
            Console.WriteLine();

            //shapes
            Console.WriteLine("Generating for Set:");
            ICollection<Shape> sortedShapes = new SortedSet<Shape>();
            CreateShapesByFactory(ref sortedShapes);
            Console.WriteLine("Sorted Shapes:");

            sortedShapes.ToList().ForEach(i => Console.WriteLine(i));

            Console.ReadKey();
        }
    }
}
