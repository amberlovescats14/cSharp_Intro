using System;
namespace first
{
    public class DateTimeLec
    {
        public DateTimeLec()
        {
        }
        public void examples()
        {
            // year month day
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            //formating a date object to string
            now.ToLongDateString(); // will give u the day of the week
            now.ToShortDateString(); // just date xx/xx/xxxx
            //or just .ToString()

            now.ToString("yyyy-mm-dd");
            now.ToString("U");

            ////////////
            /////TIME SPAN //////

            //one hour , two minute, three seconds
            var timeSpan = new TimeSpan(1, 2, 3);

            //var timeSpan2 = new TimeSpan


        }
    }
}
