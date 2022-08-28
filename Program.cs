using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string password="exit";
            string input=null;

            while (input != password)
            {
                Console.WriteLine("Пароль:");
                input = Console.ReadLine();  
            }

            Console.WriteLine("Верно");
        }
    }
}
