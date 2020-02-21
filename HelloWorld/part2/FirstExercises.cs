using System;
namespace first.part2
{
    public class FirsExercises
    {
        public FirsExercises()
        {
           
        }
        //
        public void sanity()
        {
            Console.WriteLine("Part two");
        }

        public string isValidNumber()
        {
            Console.WriteLine("Please enter a number: ");
            if (Console.ReadLine() is int) return "Valid";
            else return "Invalid";
        }

        public void displayLargestNumber()
        {
            //not checking for validation:: just writing code
            Console.WriteLine("Please enter two numbers");
            Console.Write("1: ");
            int inputOne = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("2: ");
            int inputTwo = int.Parse(Console.ReadLine());

            int greatestNumber = Math.Max(inputOne, inputTwo);
            Console.WriteLine("Greatest number: "+ greatestNumber);
        }

        public void checkImageDemensions()
        {
            Console.Write("Width of image: ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Height of image: ");
            int height = int.Parse(Console.ReadLine());

            String demensions = height > width ? "Portrait" : "Landscape";
            Console.WriteLine("The image is "+demensions);
        }

    }
}
