using System;
using System.Text;

namespace first
{
    public class StringBuilderLec
    {
        public StringBuilderLec()
        {
        }

        public void examplesOfStringBuilder()
        {
            var builder = new StringBuilder()
                .Append('-', 10)
                .AppendLine()
                .Append("HEAD");
            //--------
            // HEAD

        }
        public void formatCurrency()
        {
            int i = 1234;
            //default is 2 decimal places $1,234.00
            string currencyWithTwoDecimalPlaces = i.ToString("C");
            string currencyWithNoDecimal = i.ToString("C0");
        }


    }
}

//! Convert.Int32()    does not thro