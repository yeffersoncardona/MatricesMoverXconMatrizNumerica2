using System;

namespace MatricesMoverXconMatrizNumerica2
{
    internal class Program
    {
        static int[] myArray = new int[] { 1, 2, -1, 1, 0, 1, 2, -1, -1, -2 };
       public static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i < myArray.Length ; i += 2)
            {
                x = x + myArray[i];
                y = y + myArray[i + 1];
            }

            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == x && j == y)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("O");
                    }
                }
                Console.WriteLine("");
            }
            
        }
    }
}
