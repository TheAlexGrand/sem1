/* Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает его индексы первого найденого
 числа или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Start();
void Start()
{
    Console.Clear();
    int rows = SetNumber("rows");
    int columns = SetNumber("columns");
    Console.WriteLine();
    int[,] matrix = GetRandomMatrix(rows, columns, 2, 9);
    PrintMatrix(matrix);
    Console.WriteLine();
    int number = SetNumber("Number");
    Console.WriteLine();
    (int, int) index = FindIndex(matrix, number);
    Console.WriteLine($"Индекс строки искомого элемента = {index.Item1}, индекс столбца = {index.Item2}");
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
            array[i, j] = rand.Next(min, max+1);
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
            Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
(int, int) FindIndex(int [,] array, int num)
{
    int rowInd = 0;
    int colInd = 0;
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if (array[i,j] == num)
            {
                rowInd = i;
                colInd = j;
                return (rowInd, colInd);
            }
          
        }
    }
        return (rowInd, colInd);
}
