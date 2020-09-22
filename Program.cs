using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape obj;

            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Triangle");
            Console.WriteLine("3. Circle");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("insert width");
                    double width = double.Parse(Console.ReadLine());

                    Console.WriteLine("insert height");
                    double height = double.Parse(Console.ReadLine());

                    obj = new Rectangle(width, height);

                    Console.WriteLine("area: " + obj.Area());

                    Console.WriteLine("omkrets: " + obj.Omkrets());


                    

                    Console.ReadKey();
                    Console.Clear();
                    Main(null);

                    break;

                case "2":
                    Console.WriteLine("insert width: ");
                    width = double.Parse(Console.ReadLine());

                    Console.WriteLine("insert height");
                    height = double.Parse(Console.ReadLine());

                    obj = new Triangle(width, height);

                    Console.WriteLine("area: " + obj.Area());

                    Console.WriteLine("omkrets: " + obj.Omkrets());


                    Console.ReadKey();
                    Console.Clear();
                    Main(null);

                    break;

                case "3":

                    Console.WriteLine("insert radie: ");
                    double radie = double.Parse(Console.ReadLine());

                    obj = new Circle(radie);

                    Console.WriteLine("area: " + obj.Area());

                    Console.WriteLine("omkrets: " + obj.Omkrets());


                    Console.ReadKey();
                    Console.Clear();
                    Main(null);

                    break;

                default:
                    Main(null);
                    break;


            }


        }
    }
}
