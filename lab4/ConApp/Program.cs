using Shapes;
using System;
using Newtonsoft.Json;

namespace ConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ellipse ellipse = new Ellipse(20, 10, 50, 15);
            Console.WriteLine(ellipse);

            var str = ellipse.JSONSerialize();
            Console.WriteLine(str);

            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            Shape el = JsonConvert.DeserializeObject<Shape>(str, settings);

            Console.WriteLine(el);
            Console.ReadKey();
        }
    }
}
