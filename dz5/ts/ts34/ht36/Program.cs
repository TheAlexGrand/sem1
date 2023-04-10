/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int SetNumber(string text ="")
{
    Console.Write($"Enter {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

 int [] FillArray (int Length, int minValue, int maxValue)
{
   int [] array = new int [Length];
   Random rand = new Random ();
   for(int i = 0; i < Length; i++) 
   {
            array[i] = rand.Next(minValue, maxValue + 1);
   }
   return array;
}

   int GetSum (int[] array)
{
    int sum = 0;
    
    for (int i = 0; i < array.Length; i++)
        if (i%2 != 0)
        {
           sum = sum + array[i];
        }
       
    return sum;
}

Console.Clear();
int size = SetNumber("length");
int min = SetNumber("MinValue");
int max = SetNumber("MaxValue");
int[] array = FillArray (size, min, max);
int sum = GetSum (array);
Console.WriteLine();
Console.WriteLine(string.Join(", ", array));
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях = {sum}");
Console.WriteLine();