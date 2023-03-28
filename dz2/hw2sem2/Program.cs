///Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
///645 -> 5
///78 -> третьей цифры нет
///32679 -> 6



Console.WriteLine("Введите число:");
string OneNum = Console.ReadLine();
int amount = OneNum.ToString().Length;
int count = Convert.ToInt32(amount);
int number = Convert.ToInt32(OneNum);
int result = 0;
int a = 10;
int b = count -3;
if (count > 3)
{
    int num3 = (int)Math.Pow(a, b);
    num3 = number / num3;
    result = num3 % 10;
    Console.WriteLine(result);
 }
else if (count == 0)
{
    result = number % 10;
    Console.WriteLine(result);
}
else;
{
    Console.WriteLine(result);
}