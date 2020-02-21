﻿using System;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            byte num = 1;
            var age = 32;

            //format string
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            var name = "amber";

            //! Converting :: cannot cast string to number, but convert
            string one = "1";
            int oneNumber = Convert.ToInt32(one);
            int oneParse = int.Parse(one);

            //! PRIMITIVES DO NOT HOLD REFERENCE TYPES
            // i still equal 1
            byte b = 1;
            int i = b;
            b = 10;
            //Console.WriteLine(i);

            Int32 refA = 1;
            Int32 refB = refA;
            refA = 10;
            Console.WriteLine("ref: "+refB);



            try
            {
                //cw
                var oneHundredString = "100";
                byte hundredByte = Convert.ToByte(oneHundredString);
                Console.WriteLine(hundredByte);
          
            }
            catch (Exception ex)

            {
                Console.WriteLine("The number could not be converted");
            }

            // if you divise two ints it will return an int not a float
            var first = 10;
            var second = 3;
            Console.WriteLine((float)first / second);


            //! Class
            var speak = new ClassLecture();
            speak.sayHello("Amber");

            new StringLec().declaringStrings();


            //! ENUM
            var method = EnumLec.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((EnumLec)methodId);


           


        }
    }
}

// 255.byte short int long float(f) *double decimal(m) char bool
//  ^I    format document
//


    // all primitive types are structured
    //