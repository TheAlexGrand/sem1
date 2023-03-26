/// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
string OneNum = Console.ReadLine();
int One = Convert.ToInt32(OneNum);
if (One <= 0)
{
    Console.WriteLine("Введите положительное число");
}
else
{
    for (int Count = 1;Count <= One; Count++)
    {
        if (Count % 2 == 0)
        {
            Console.Write($"{Count} ");
        }
    }
}