/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int SetNumber(string text ="")
{
    Console.Write($"Enter {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int [] FillArray (int Length)
{
   int [] array = new int [Length];
   Random rand = new Random ();
   for(int i = 0; i < Length; i++) 
   {
            array[i] = rand.Next(100, 1000);
   }
   return array;
}

   int GetCount (int[] array)
{
    int count = 0;
    
    for (int i = 0; i < array.Length; i++)
        if (array[i]%2 == 0)
        {
           count++;
        }
       
    return count;
}

Console.Clear();
int size = SetNumber(" length");
int[] array = FillArray (size);
int count = GetCount (array);
Console.WriteLine();
Console.WriteLine(string.Join(", ", array));
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве = {count}");
Console.WriteLine();