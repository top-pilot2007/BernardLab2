using System;

namespace BernardLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            
            Console.WriteLine("Enter Length: ");
            var userLength = Console.ReadLine();
            double length = Convert.ToDouble(userLength);

            Console.WriteLine("Enter Width: ");
           var userWidth = Console.ReadLine();
           double width = Convert.ToDouble(userWidth);

           double area = length * width;
            double perimeter = length + length + width + width;

           Console.WriteLine($"Area {area}");
           Console.WriteLine($"Perimeter {perimeter}");

           Console.WriteLine("Continue? (y/n) ");
           var continueYesNo = Console.ReadLine();

             
            while
                (continueYesNo == "y") 
            
            {
                Console.WriteLine("Enter Length: ");
                var ContinueUserLength = Console.ReadLine();
                double ContinueLength = Convert.ToDouble(ContinueUserLength);

                Console.WriteLine("Enter Width: ");
                var ContinueUserWidth = Console.ReadLine();
                double ContinueWidth = Convert.ToDouble(ContinueUserWidth);

                double ContinueArea = ContinueLength * ContinueWidth;
                double ContinuePerimeter = ContinueLength + ContinueLength + ContinueWidth + ContinueWidth;

                Console.WriteLine($"Area {ContinueArea}");
                Console.WriteLine($"Perimeter {ContinuePerimeter}");

               Console.WriteLine("Continue? (y/n) ");
                var stillContinueYesNo = Console.ReadLine();
                if
                    (stillContinueYesNo == "n") { Console.WriteLine("Goodbye");
                    break;
                }

            }
            
            if 
                    (continueYesNo== "n") { Console.WriteLine("Goodbye"); }
        }
    }
}
