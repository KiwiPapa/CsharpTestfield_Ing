using System;

namespace SimpleConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    Console.WriteLine(i.ToString() + " " + j.ToString());
                }
            }
        }
    }
}
