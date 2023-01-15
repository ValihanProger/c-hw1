// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число которое хотите проверить: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2 == 0)
{
    Console.Write($"{number} -> да");
}
else if (number%2 !=0)
{
    Console.Write($"{number} -> нет");
}
else
{
    Console.Write("Нормальное число впиши, понял?");
}