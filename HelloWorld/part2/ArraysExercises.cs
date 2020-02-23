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
                Console.WriteLine(name[i - 1]);
                reverseNameArray[name.Length - i] = name[i - 1];
            }
            var reversedString = new string(reverseNameArray);
            Console.WriteLine("Your name reversed: " + reversedString);

        }





    }
}
