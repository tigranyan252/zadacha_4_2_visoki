using System;

namespace zadacha_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int[,] arr = new int[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];
            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
                {
                    arr[i, j] = ((i == 0 || j == 0) ? 1 : arr[i - 1, j] + arr[i, j - 1]);
                    Console.Write("{0,5}", arr[i, j]);
                }
                Console.WriteLine("");
            }
        }
    }
}
