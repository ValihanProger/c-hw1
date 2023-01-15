// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (first>second)
{
    Console.WriteLine($"Число {first} большее, а число {second} меньшее.");
    max = first;
    Console.Write($"Максимальное число = {max}");
}
else if (first==second)
{
    Console.Write($"Число {first} = {second}");
    max = first;
    Console.Write($"Максимальное число = {max}");
}
else
{
    Console.WriteLine($"Число {second} большее, а число {first} меньшее.");
    max=second;
    Console.Write($"Максимальное число = {max}");
}