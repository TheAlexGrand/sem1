/// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
///Например, задан массив:
///1 4 7 2
///5 9 2 3
///8 4 2 4
///В итоге получается вот такой массив:
///7 4 2 1
///9 5 3 2
///8 4 4 2


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
    SortArray(matrix);
    PrintMatrix(matrix);
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

void SortArray(int[,] array)
{

    int tmp;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    tmp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = tmp;
                }
            }
        }
    }
}