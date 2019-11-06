using System;

namespace _06._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int price = 0;

            if (0 > age || age > 122)
            {
                Console.WriteLine("Error!");
                return;
            }

            switch (day)
            {
                case "Weekday":
                    if ((0<= age && age <= 18) ||(64 < age && age <= 122))
                    {
                        price += 12;
                    }
                    else if (18 < age && age <= 64)
                    {
                        price += 18;
                    }
                    break;
                case "Weekend":
                    if ((0 <= age && age <= 18) || (64 < age && age <= 122))
                    {
                        price += 15;
                    }
                    else if (18 < age && age <= 64)
                    {
                        price += 20;
                    }
                    break;
                case "Holiday":
                    if (0 <= age && age <= 18)
                    {
                        price += 5;
                    }
                    else if (18 < age && age <= 64)
                    {
                        price += 12;
                    }
                    else if (64 < age && age <= 122)
                    {
                        price += 10;
                    }
                    break;

                default: Console.WriteLine("Error!");
                    break;
            }

            Console.WriteLine($"{price}$");
        }
    }
}