///Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число 1:");
string OneNum = Console.ReadLine();
int One = Convert.ToInt32(OneNum);

Console.WriteLine("Введите число 2: ");
string TwoNum = Console.ReadLine();
int Two = Convert.ToInt32(TwoNum);

if (One > Two) {
    Console.WriteLine($"Большее число {One}, меньшее {Two}");
} 
else {
    Console.WriteLine($"Большее число {Two}, меньшее {One}");
}