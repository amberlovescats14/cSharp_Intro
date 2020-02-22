using System;
namespace first
{
    public class Loops
    {
        public Loops()
        {
        }

        // SAME FORMAT FOR LOOPS
        public void basicLoopFormat()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("index: "+i);
            }
        }

        public void forEachLoopFormat()
        {
            var numbers = new int[] { 1, 2, 3 };
            foreach (var num in numbers)
            {
                Console.WriteLine("Num: "+num);      
            }
        }

        public void whileLoopFormat()
        {
            var i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0) Console.WriteLine("Even");
                i++;
            }

            //! Another example
            while (true)
            {
                Console.Write("Type your name: ");
                String input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input)) break;
                else Console.WriteLine("@Echo "+ input);
            }

        }

        public void doWhileLoop()
        {

            do
            {
                var random = new Random();
                //! between 1-10
                int number = random.Next(1,10);
                if (number % 2 != 0) break;
            } while (true);
        }


        //! BYTE CHAR
        public void randomChars()
        {
            var passwordLength = 10;
            var bucket = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
            {
                var random = new Random();
                bucket[i] = (char)('a' + random.Next(0, 26));

            }
            var joinedArray = new String(bucket);
            Console.WriteLine("Array to String: "+ joinedArray);
        }

    }
}
