// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
using static System.Console;
Clear();
WriteLine("Введите число a: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите число b: ");
int b = Convert.ToInt32(ReadLine());
WriteLine("Введите число c: ");
int c = Convert.ToInt32(ReadLine());
int max = a;
if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
WriteLine($"Макcимальное число: {max}");
