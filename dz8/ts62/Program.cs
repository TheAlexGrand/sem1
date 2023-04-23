 /*
 Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до M.
 N = 5. -> "5, 4, 3, 2, 1"
 N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"
 */
 
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
NaturalFrom1To2(number1, number2);


void NaturalFrom1To2(int number1, int number2)
{
    if (number2 > number1)
    {
        return;
    }
    else
    {
        NaturalFrom1To2(number1, number2 + 1);
        Console.Write(number2 + " ");
    }
}
