/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Start();
void Start()
{
    Console.Clear();
    Console.WriteLine("Введите параметры первой матрцы:");
    int rows1 = SetNumber("rows");
    int columns1 = SetNumber("columns");
    int min1 = SetNumber("min");
    int max1 = SetNumber("max");
    Console.WriteLine();
    int[,] matrix1 = GetRandomMatrix(rows1, columns1, min1, max1);
    PrintMatrix(matrix1);
    Console.WriteLine();
    Console.WriteLine("Введите параметры второй матрцы:");
    int rows2 = SetNumber("rows");
    int columns2 = SetNumber("columns");
    int min2 = SetNumber("min");
    int max2 = SetNumber("max");
    Console.WriteLine();
    int[,] matrix2 = GetRandomMatrix(rows2, columns2, min2, max2);
    PrintMatrix(matrix2);
    Console.WriteLine();
    if (columns1 != rows2)
    {
         Console.WriteLine("Результат умножения невозможен");
    }
    else
    {
       int[,] ResultMatrix = DivMatrix(matrix1, matrix2);
       Console.WriteLine("Результирующая матрица:");
       PrintMatrix(ResultMatrix); 
    }
    
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
            Console.Write($" {matrix[i, j]:D2}   ");
        }
        Console.WriteLine();
    }
}

int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    var ResultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    
        for (int i = 0; i < ResultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < ResultMatrix.GetLength(1); j++)
            {
                ResultMatrix[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    ResultMatrix[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    return ResultMatrix;
}