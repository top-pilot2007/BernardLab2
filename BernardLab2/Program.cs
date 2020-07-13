using System;

namespace BernardLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            
            var continueYesNo = "y";

            while (continueYesNo == "y")
            {
                Console.Write("Enter Length: ");
                var userLength = Console.ReadLine();
                double length = Convert.ToDouble(userLength);

                Console.Write("Enter Width: ");
                var userWidth = Console.ReadLine();
                double width = Convert.ToDouble(userWidth);

                double area = length * width;
                double perimeter = length + length + width + width;

                Console.WriteLine($"Area {area}");
                Console.WriteLine($"Perimeter {perimeter}");

                
                Console.WriteLine("Continue? (y/n) ");
                continueYesNo = Console.ReadLine().ToLower().Trim();
            }
            Console.WriteLine("Goodbye!");
        }
    }
}
