/// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.Clear();
Console.Write("Введите пятизначное число :");
string num = (Console.ReadLine());
int Length = num.Length;
char[] numArr = num.ToCharArray();
if (Length < 5 || Length > 5)
{
    Console.WriteLine("Вы ввели не пятизначное число ");
}
else
{
if (num[0] == num[4] && num[1] == num[3])
{
    Console.WriteLine("Число является палиндромом ");
}
else
{
    Console.WriteLine("Число не является палиндромом ");
}
}

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Enter X1  ");
double X1 = double.Parse(Console.ReadLine());
Console.Write("Enter Y1  ");
double Y1 = double.Parse(Console.ReadLine());
Console.Write("Enter Z1  ");
double Z1 = double.Parse(Console.ReadLine());
Console.Write("Enter X2  ");
double X2 = double.Parse(Console.ReadLine());
Console.Write("Enter Y2  ");
double Y2 = double.Parse(Console.ReadLine());
Console.Write("Enter Z2  ");
double Z2 = double.Parse(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2) + Math.Pow((Z2 - Z1), 2));

Console.WriteLine($"Расстояние между точками равно: {AB}");
Console.WriteLine();

///Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число N: ");
string strNumN = Console.ReadLine();
int numN = Convert.ToInt32(strNumN);
int count = 1;


Console.WriteLine($"Кубы чисел от 1 до {numN}:");
while (count <= numN)
{
    Console.Write($" {Math.Pow((count), 3)} ");
    count++;
}
Console.WriteLine();

