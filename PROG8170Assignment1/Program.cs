using System;

namespace PROG8170Assignment1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PROG8170 - Assingment 1");
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Please insert an integer value for the length of the rectangle:");
            int length = GetMeasure();
            rectangle.SetLength(length);

            Console.WriteLine();

            Console.WriteLine("Please insert an integer value for the width of the rectangle:");
            int width = GetMeasure();
            rectangle.SetWidth(width);

            int optionSelected = -1;

            while (optionSelected != 7)
            {
                optionSelected = GetOption();
                
                Console.WriteLine();
                
                int result;
                switch (optionSelected)
                {
                    case 1:
                        result = rectangle.GetLength();
                        Console.WriteLine("The length of the rectangle is: " + result);
                        break;
                    case 2:
                        Console.WriteLine("Please insert a new length for the rectangle:");
                        int newLength = GetMeasure();
                        rectangle.SetLength(newLength);
                        break;
                    case 3:
                        result = rectangle.GetWidth();
                        Console.WriteLine("The width of the rectangle is: " + result);
                        break;
                    case 4:
                        Console.WriteLine("Please insert a new width for the rectangle:");
                        int newWidth = GetMeasure();
                        rectangle.SetWidth(newWidth);
                        break;
                    case 5:
                        result = rectangle.GetPerimeter();
                        Console.WriteLine("The perimeter of the rectangle is: " + result);
                        break;
                    case 6:
                        result = rectangle.GetArea();
                        Console.WriteLine("The area of the rectangle is: " + result);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("See you next time!");
            System.Environment.Exit(1);
        }
        public static int GetMeasure()
        {
            int measure = -1;
            while (measure <= 0)
            {
                try
                {
                    string measureString = Console.ReadLine();
                    measure = Convert.ToInt32(measureString);
                    if (measure <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("The value inserted is not valid. Please insert an integer value greater than zero.");
                    }
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("The value inserted is not valid. Please insert an integer value greater than zero.");
                }
            }
            return measure;
        }

        public static int GetOption()
        {
            int optionSelected = -1;
            while (optionSelected <= 0 || optionSelected > 7)
            {
                Console.WriteLine();
                Console.WriteLine("Please select one of the options bellow:");
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit");
                try
                {
                    string optionString = Console.ReadLine();
                    optionSelected = Convert.ToInt32(optionString);
                }
                catch
                {
                    Console.WriteLine("The value inserted is not valid.");
                }
            }
            return optionSelected;
        }
    }
}
