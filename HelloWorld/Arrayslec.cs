using System;
namespace first
{
    public class Arrayslec
    {
        public Arrayslec()
        {
        }
        // multi dementional
        // rectangular::: exact same sizes ...3 rows of 5
        // jagged array::: is an array of arrays....any size

         public void arraySyntax()
        {
            var matrix = new int[2, 3]; // u can also decare variables like this


            var jagged = new int[3][];
            jagged[0] = new int[4];
            jagged[1] = new int[2];
            jagged[2] = new int[7];

            var numbers = new[] { 1, 2, 3 };
            var indexOfTwo = Array.IndexOf(numbers, 2);

            // put the array, start , and end
            // will set numbers to 0, booleans = false , and other null
            Array.Clear(numbers, 1, 1);

            var moreNumbers = new int[3];
            // array to copy from, destination, and how many
            Array.Copy(numbers, moreNumbers, 3);


            var thirdNumbers = new[] { 5, 8, 9 };
            Array.Sort(thirdNumbers);

            Array.Reverse(thirdNumbers);
            


        }   







    }
}
