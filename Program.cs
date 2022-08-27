using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            while (true)
            {
                Console.WriteLine("На выход!");
                answer = Console.ReadLine();
                if (answer == "exit")
                {
                    Console.WriteLine("быбы");
                    break;
                }
            }  
        }
    }
}
