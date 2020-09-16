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
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Triangle");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("insert width");
                    double width = double.Parse(Console.ReadLine());

                    Console.WriteLine("insert height");
                    double height = double.Parse(Console.ReadLine());

                    var instance = new Rectangle(width, height);

                    Console.WriteLine("area: " + instance.Area());

                    Console.WriteLine("omkrets: " + instance.Omkrets());


                    

                    Console.ReadKey();
                    Console.Clear();
                    Main(null);

                    break;

                case "2":
                    Console.WriteLine("insert width: ");
                    width = double.Parse(Console.ReadLine());

                    Console.WriteLine("insert height");
                    height = double.Parse(Console.ReadLine());

                    var area = new Triangle(width, height);

                    Console.WriteLine("area: " + area.Area());
                    Console.WriteLine("Omkrets: " + area.Omkrets());        
                    

                    Console.ReadKey();
                    Console.Clear();
                    Main(null);

                    break;

            }


        }
    }
}
