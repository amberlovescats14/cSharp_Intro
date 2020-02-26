using System;
using System.Collections.Generic;

namespace first.part2
{
    public class ArraysExercises
    {
        public ArraysExercises()
        {
        }

        // ignore input validation

        // #1
        public void askHowManyNames()
        {
            var listOfNames = new List<String>();
            Console.WriteLine("Please enter a name or press enter to exit:");
            while (true)
            {
                var name = Console.ReadLine().Trim();
                Console.WriteLine(); //clear
                if (String.IsNullOrEmpty(name)) break;
                listOfNames.Add(name);
                Console.Write("next: ");
            }
            displayNamesAndLikes(listOfNames);

        }


        private void displayNamesAndLikes(List<String> listOfNames)
        {
            var display = "";
            switch (listOfNames.Count)
            {
                case 0:
                    display = "0 likes"; break;
                case 1:
                    display = String.Format("{0} likes your post.",
                        listOfNames[0]);
                    break;
                case 2:
                    display = String.Format("{0} and {1} like your post.",
                        listOfNames[0], listOfNames[1]);
                    break;
                default:
                    display = String.Format("{0}, {1}, and {2} other people like your post. ",
                        listOfNames[0], listOfNames[1], (listOfNames.Count - 2));
                    break;
            }
            Console.WriteLine(display);

        }

        // #2
        public void reverseName()
        {

            Console.Write("Please enter your name: ");
            var name = Console.ReadLine();
            var reverseNameArray = new char[name.Length];
            for (int i = name.Length; i > 0; i--)
            {
                reverseNameArray[name.Length - i] = name[i - 1];
            }
            var reversedString = new string(reverseNameArray);
            Console.WriteLine("Your name reversed: " + reversedString);

        }

        // #3
        public void getFiveUniqueNumbers()
        {
            var uniqueNumbers = new List<int>();
            Console.WriteLine("Please enter 5 unique numbers...");
            while (true)
            {
                Console.Write("unique number: ");
                var number = int.Parse(Console.ReadLine());
                if (uniqueNumbers.Contains(number))
                {
                    Console.WriteLine(number+" is already in the list...");
                    continue;
                }
                uniqueNumbers.Add(number);
                if (uniqueNumbers.Count == 5) break;

            }
            Console.WriteLine("Unique number list: "+ string.Join(",",uniqueNumbers));
        }


        // #4
        public void getFiveNumbers()
        {
            //only display uniques
            var numbers = new List<int>();
            Console.WriteLine("Enter some numbers, type quit to exit: ");
            while (true)
            {
                var input = Console.ReadLine();
                if(input.ToLower().Equals("quite")) break;
                var parsedInput = int.Parse(input);
                if (!numbers.Contains(parsedInput))
                    numbers.Add(parsedInput);
            }

            Console.WriteLine("Thank you, here is your set: " + string.Join(",", numbers));
        }

        //# 5
        public void getThreeSmallesNumbers()
        {
            Console.WriteLine("Please enter a set of numbers seperated by a coma: ");
            var numbersInChars = new List<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (!String.IsNullOrEmpty(input))
                {
                    var split = input.Split(',');
                    if (split.Length >= 5)
                    {
                        numbersInChars.AddRange(split);
                        break;
                    }
                    Console.WriteLine("input must be at least 5 numberes long");
                }
                Console.Write("numbers: ");

            }
            var smallestThreeNumbers = new List<Int32>();
            numbersInChars.Sort();
            numbersInChars.Reverse();
            for (int i = 0; i < numbersInChars.Count; i++)
            {
                if (i == 3) break;
                smallestThreeNumbers.Add(Convert.ToInt32(numbersInChars[i]));
            }
            Console.WriteLine(String.Join("", smallestThreeNumbers));
        }


    }
}
