using System;

namespace Task4
{
    class MyDate
    {
        public MyDate(DateTime date)
        {
            Date = date;
        }

        public DateTime Date { get; }


        public static int operator -(MyDate d1, MyDate d2)
        {
            TimeSpan diff = d1.Date - d2.Date;

            return diff.Days;
        }

        public static MyDate operator +(MyDate d1, int days)
        {
            MyDate myDate = new MyDate(d1.Date.AddDays(days));

            return myDate;
        }

        public override string ToString()
        {
            return $"{Date.ToShortDateString()}";
        }
    }
}
