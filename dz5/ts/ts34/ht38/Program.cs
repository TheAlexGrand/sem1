/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int SetNumber(string text ="")
{
    Console.Write($"Enter {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

 double SetDoubleNumber(string text ="")
{
    Console.Write($"Enter {text}: ");
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
} 



 double [] FillArray (int Length, double MinValue, double MaxValue)
 {
   double [] array = new double [Length];
   Random rand = new Random ();
   for(int i = 0; i < Length; i++) 
   {
            array[i] = MinValue + rand.NextDouble() * (MaxValue - MinValue);
   }
   return array;
}

   (double, double) GetMinMax (double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    return (min, max);
}

Console.Clear();
int size = SetNumber("length");
double minval = SetDoubleNumber("MinValue");
double maxval = SetDoubleNumber("MaxValue"); 
double[] array = FillArray (size, minval, maxval);
(double, double) minmax = GetMinMax (array);
double dif = minmax.Item2 - minmax.Item1;
Console.WriteLine();
Console.WriteLine(string.Join(", ", array));
Console.WriteLine();
Console.WriteLine($"Разница между наибольшим и наименьшим элементом = {dif}");
Console.WriteLine();