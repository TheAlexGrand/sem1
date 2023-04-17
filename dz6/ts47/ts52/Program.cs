/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

using System;
class Program
{
    static void Main()
    {
        Start();
        void Start()
        {
            Console.Clear();
            int rows = SetNumber("rows");
            int columns = SetNumber("columns");
            int min = SetNumber("min");
            int max = SetNumber("max");
            Console.WriteLine();
            int[,] matrix = GetRandomMatrix(rows, columns, min, max);
            PrintMatrix(matrix);
            Console.WriteLine("average");
            GetArif(matrix);
            Console.WriteLine();
            Console.WriteLine();
        }

        int SetNumber(string text = "")
        {
            Console.Write($"Enter number {text}: ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        int[,] GetRandomMatrix(int rows, int columns, int min, int max)
        {
            int[,] array = new int[rows, columns];
            var rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = rand.Next(min, max + 1);
                }
            }
            return array;
        }
        void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLongLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}   ");
                }
                Console.WriteLine();
            }
        }
        void GetArif(int[,] array)
        {

            for (int j = 0; j < array.GetLength(1); j++)
            {
                double sum = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    sum += array[i, j];
                }
                Console.Write($"{Math.Round(sum / array.GetLength(0), 1)} ");
            }
        }


    }
}