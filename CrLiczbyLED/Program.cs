using System;

namespace CrLiczbyLED
{
    internal class Program
    {
        static void Main()
        {
            string Liczba = Console.ReadLine();

            string[] cyfryLED =
            {
                " _ | ||_|", // 0
                "     |  |", // 1
                " _  _||_ ", // 2
                " _  _| _|", // 3
                "   |_|  |", // 4
                " _ |_  _|", // 5
                " _ |_ |_|", // 6
                " _   |  |", // 7
                " _ |_||_|", // 8
                " _ |_|  |"  // 9
            };

            for (int i = 0; i < 3; i++)
            {
                foreach (char LED in Liczba)
                {
                    int index = int.Parse(LED.ToString());
                    Console.Write(cyfryLED[index].Substring(i * 3, 3));
                }
                Console.WriteLine();
            }
        }
    }
}