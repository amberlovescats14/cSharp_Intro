using System;
namespace first.part2
{
    public class LoopExercises
    {
        public LoopExercises()
        {
        }

        public int getAmountOfNumbersDivisibleByThree()
        {
            int count = 0;
            for (int i = 3; i <= 100; i++)
            {
                if (i % 3 == 0) count++;
                else continue;
            }
            return count;
        }

        public int getSumOfUserInput()
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Please enter a number or ok to exit: ");
                var input = Console.ReadLine();
                if (input.ToLower().Equals("ok")) break;
                sum += int.Parse(input);
            }
            return sum;
        }

        public int recursiveFactorial(int num)
        {
            if (num == 2) return 2;
            return num * recursiveFactorial(num - 1);
        }

        public void askUserToGuessTheNumber()
        {
            var random = new Random().Next(1, 10);
            Console.WriteLine("random: "+random);
            var guesses = 4;
            while (true)
            {
                Console.Write("Please guess a number: ");
                var guess = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if( guess == random)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                if (guesses == 0)
                {
                    Console.WriteLine("You lost.");
                    break;
                }
                guesses--;

            }
            
        }


        public void getLargestNumbers()
        {
            Console.Write("Please enter a series of numbers seperated by a coma: " );
            String[] numbers = Console.ReadLine().Split(",");
            int[] parsedNumbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                parsedNumbers[i] = int.Parse(numbers[i]);
            }
            Array.Sort(parsedNumbers);
            foreach (var item in parsedNumbers)
            {
                Console.WriteLine("item: "+item);
            }

            Console.WriteLine("Highest number: "+ (parsedNumbers.Length-1));
        }


    }
}
