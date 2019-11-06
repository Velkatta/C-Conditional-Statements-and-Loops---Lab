using System;

namespace _12._Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string number = Console.ReadLine();
                int count = int.Parse(number);
                Console.WriteLine("It is a number.");                
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");           
            }
        }
    }
}