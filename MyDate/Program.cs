using System;

namespace MyDate
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date(13, 5, 2010);

            Console.WriteLine($"Hi, today's date is! {date.GetDate()}");
        }
    }
}
