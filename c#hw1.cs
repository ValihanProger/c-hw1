// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78

Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int third  = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (first>second)
{
    max=first;
    if (max>third)
    {
        Console.Write($"Максимальное из трех чисел = {max}");
    }
    else
    {
        max = third;
        Console.Write($"Максимальное из трех чисел = {max}");
    }
}
else 
{
    max=second;
    if (max>third)
    {
        Console.Write($"Максимальное из трех чисел = {max}");
    }
    else
    {
        max=third;
        Console.Write($"Максимальное из трех чисел = {max}");
    }
}


