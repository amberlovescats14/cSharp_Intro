using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace first.part2
{
    public class StringBuilderExercise
    {
        public StringBuilderExercise()
        {
        }

        // #1
        public string areNumbersConsecutive()
        {
            var response = "Consecutive";
            Console.WriteLine("Please enter a set of numbers seperated by dashes: ");
            var inputArray = Console.ReadLine().Split('-');
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray.Length == 1) break;
                if(int.Parse(inputArray[i]) != (int.Parse(inputArray[i-1])+ 1))
                {
                    response = "Not Consecutive";
                    break;
                }
            }
            return response;
        }


        // #2
        public void checkForDuplicates()
        {
            var uniqueNumbers = new List<int>();
            Console.WriteLine("Please enter a few numbers seperated by a hyphen: ");
            var input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                var response = "No duplicates";
                var inputArr = input.Split('-');
                foreach (var item in inputArr)
                {
                    if (uniqueNumbers.IndexOf(Convert.ToInt32(item)) >= 0)
                    {
                        response = "Duplicate"; break;
                    }
                    else uniqueNumbers.Add(Convert.ToInt32(item));
                }
                Console.WriteLine(response);
            }

        }

        // #3
        public string getValidTime()
        {
            Console.WriteLine("Please enter time in 24hr format: ");
            var input = Console.ReadLine();
            if (isValidTime(input)) return "Okay";
            else return "Invalid time";
        }

        private bool isValidTime(string userInput)
        {
            Regex time =
             new Regex(@"[0-2][0-9]:[0-5][0-9]");
            return time.IsMatch(userInput);
        }

        public void regexpTest(string input)
        {
            Regex regex = new Regex(@"[a]");
            Console.WriteLine(regex.IsMatch(input));
        }

        //#4
        public string translateToPascalCase(string input)
        {
            input = input.ToLower();
            var words = input.Split(' ');
            StringBuilder builder = new StringBuilder();
            foreach (var item in words)
            {
                var pascalWord = item[0].ToString().ToUpper() + item.Substring(1);
                builder.Append(pascalWord);
            }
            return builder.ToString();
        }

        //# 5
        public int getVowelCount(string word)
        {
            var numberOfVowels = 0;
            for (int i = 0; i < word.Length; i++)
            {
                var lowerCaseStringOfLetter = word[i].ToString().ToLower();
                switch (lowerCaseStringOfLetter)
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u": numberOfVowels++; break;    
                    default:
                        break;
                }
            }
            return numberOfVowels;
        }




    }
}
