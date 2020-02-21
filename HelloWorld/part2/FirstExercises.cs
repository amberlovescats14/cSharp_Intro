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

        //enter speed limit
        // speed of a car
        // for every 5 over the speed limit calculate 1 demerit
        //if more than 12 demerits...should display "License Suspended"
        public void takingRadar()
        {
            Console.Write("What speed is your car going? ");
            int carSpeed = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("What is the speed limit? ");
            int speedLimit = int.Parse(Console.ReadLine());
            int differenceInSpeed = carSpeed - speedLimit;
            if(differenceInSpeed > 0)
            {
                int demerits = differenceInSpeed / 5;
                if (demerits > 12) Console.WriteLine("Licence supsended"); 
                else Console.WriteLine(demerits + " given");
            }
            else Console.WriteLine("Thank you for not speeding.");
        }

    }
}
