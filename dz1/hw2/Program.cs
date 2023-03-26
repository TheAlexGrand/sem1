///Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число 1:");
string OneNum = Console.ReadLine();
int One = Convert.ToInt32(OneNum);

Console.WriteLine("Введите число 2: ");
string TwoNum = Console.ReadLine();
int Two = Convert.ToInt32(TwoNum);

Console.WriteLine("Введите число 3:");
string ThreeNum = Console.ReadLine();
int Three = Convert.ToInt32(ThreeNum);

int Max = One;

if (Max < Two) {
    Max = Two;
}
if (Max < Three){
    Max = Three;
}
Console.WriteLine($"Большее число равно: {Max}");