using System;

namespace _03._Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());

            mins += 30;

            if (mins > 59)
            {
                hour++;
                mins -= 60;
            }
            if (hour > 23)
            {
                hour = 0;
            }

            Console.WriteLine($"{hour}:{mins:d2}");
        }
    }
}