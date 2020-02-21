using System;
namespace first
{
    public class StringLec
    {
        public StringLec()
        {
        }

        public void declaringStrings()
        {

            //! STRING ARE IMMUTABLE

            string firstName = "Amber";
            string lastName = "Jones";
            string fullName = string.Format("{0} {1}", firstName, lastName);
            Console.WriteLine("Full name {0}", fullName);

            var numberes = new int[3] { 1, 2, 3 };
            string list = string.Join(",", numberes);
            Console.WriteLine("Array as list: "+list);

            //! VERBATIM STRING
            string path = @"c:\projects\
                            I PRESSSED ENTER \project1\folder1";
            Console.WriteLine("path: "+path);

        

        }
    }
}
