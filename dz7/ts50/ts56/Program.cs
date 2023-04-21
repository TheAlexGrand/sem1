/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

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
    Console.WriteLine();
    int[] sumArr=GetSumArray(matrix);
    GetMinSum(sumArr); 
    Console.WriteLine();
}

int SetNumber(string text = " ")
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

int[] GetSumArray(int[,] Array)
{
    int[] result = new int[Array.GetLength(0)];
    int index = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            result[index]+= Array[i,j];
        }
        index++;
    }
    return result;
}

void GetMinSum (int[] array)
{
    int min = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
      if (array[i] < min)
        {
            min = array[i];
            index = i;
        }
    
    Console.WriteLine ($"Наименьшаяя сумма элементов находиться в {index+1} строке");
}