using Prueba.Shapes;
using System;
using System.Diagnostics;
using System.Reflection;

namespace StringManipulation
{
    class Program
    {
        static List<Shape> lstShapes = new List<Shape>();
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Enter a shape and the values");
            Console.WriteLine("2) List of shapes");
            Console.WriteLine("3) Check point");
            Console.WriteLine("4) Load file");
            Console.WriteLine("5) Help");
            Console.WriteLine("6) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AddShape();
                    return true;
                case "2":
                    ListShapes();
                    return true;
                case "3":

                    CheckIfIsInShape();
                    return true;
                case "4":
                    LoadFile();
                    return true;
                case "5":
                    Console.WriteLine("HELP");
                    Console.ReadKey();
                    return true;
                case "6":
                    return false;
                default:
                    return true;
            }
        }

        private static void InsertShape(string[] inputValues)
        {
            switch (inputValues[0].ToLower())
            {
                case "circle":
                    Shape circle = new Circle(lstShapes.Count + 1, Convert.ToDouble(inputValues[1]), Convert.ToDouble(inputValues[2]), Convert.ToDouble(inputValues[3]));
                    lstShapes.Add(circle);
                    Console.WriteLine(circle.ToString());
                    Console.ReadKey();
                    return;
                case "rectangle":
                    Shape rectangle = new Rectangle(lstShapes.Count + 1, Convert.ToDouble(inputValues[1]), Convert.ToDouble(inputValues[2]), Convert.ToDouble(inputValues[3]), Convert.ToDouble(inputValues[3]));
                    lstShapes.Add(rectangle);
                    Console.WriteLine(rectangle.ToString());
                    Console.ReadKey();
                    return;
                case "square":
                    Shape square = new Square(lstShapes.Count + 1, Convert.ToDouble(inputValues[1]), Convert.ToDouble(inputValues[2]), Convert.ToDouble(inputValues[3]));
                    lstShapes.Add(square);
                    Console.WriteLine(square.ToString());
                    Console.ReadKey();
                    return;
                default:
                    Console.WriteLine("shape unknown");
                    Console.ReadKey();
                    return;

            }
        }


        private static void AddShape()
        {
            try
            {
                Console.WriteLine("Enter the shape and the values. for example: circle 1,7 -5,05 6,9 ");

                string[] inputValues = Console.ReadLine().Split(' ');
                //@TODO validate input value
                InsertShape(inputValues);
                // Add shapes
                Console.ReadKey();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.ReadKey(true);
            }

        }
        private static void LoadFile()
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"files\shapes.txt");
            string[] lines = System.IO.File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] inputValues = line.Split(' ');
                InsertShape(inputValues);
            }
            System.Console.ReadKey();

        }
        private static void ListShapes()
        {
            lstShapes.ForEach(c => Console.WriteLine(c.ToString()));
            Console.ReadKey();
        }
        private static void CheckIfIsInShape()
        {
            if (lstShapes.Count == 0)
            {
                Console.WriteLine("There are no shapes in the List. Please add one");
            }
            
            Console.WriteLine("Enter X coordinate ");
            double inputX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y coordinate ");
            double inputY = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Shape(s) that are in the given coordinates: ");
            List<Shape> lstShapesInside = lstShapes.Where(c => c.IsInShape(inputX, inputY) == true).ToList();
            lstShapesInside.ForEach(c => Console.WriteLine(c.ToString()));
            Console.ReadKey();
        }

    }
}