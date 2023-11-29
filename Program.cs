using System;


namespace TaskOne
{
    internal class Program
    {
        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] a =
            {
                { 7, 3, 2 },
                { 4, 9, 6 },
                { 1, 8, 5 }
            };

            PrintArray(a);
            int rows = a.GetLength(0);
            int columns = a.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int k = 0; k < rows; k++)
                    {
                        for (int l = 0; l < columns; l++)
                        {
                            if (a[i, j] < a[k, l])
                            {
                                int temp = a[i, j];
                                a[i, j] = a[k, l];
                                a[k, l] = temp;
                            }
                        }
                    }
                }
            }
            PrintArray(a);
        }
    }
    
}
