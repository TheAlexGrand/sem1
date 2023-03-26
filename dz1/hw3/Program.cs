///Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число 1:");
string OneNum = Console.ReadLine();
int One = Convert.ToInt32(OneNum);

if (One % 2 == 0){
     Console.WriteLine($"Число {One} является четным");
}
else {
    Console.WriteLine($"Число {One} является нечетным");
}