/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Start();
void Start()
{
    Console.Clear();
    int rows = SetNumber("m");
    int columns = SetNumber("n");
    int min = SetNumber("min");
    int max = SetNumber("max");
    Console.WriteLine();
    double[,] matrix = GetMatrix(rows, columns, min, max);
    PrintMatrix(matrix);
    Console.WriteLine();
}

int SetNumber(string text = "")
{
    Console.Write($"Enter number {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
double[,] GetMatrix(int rows, int columns, int min, int max)
{
    double[,] array = new double[rows, columns];
    var rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round((min + rand.NextDouble() * (max - min)),1);
        }
    }
    return array;
}
void PrintMatrix(double[,] matrix)
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