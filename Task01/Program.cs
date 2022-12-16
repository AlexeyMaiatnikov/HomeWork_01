// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
using static System.Console;
Clear();
WriteLine("Введите число a: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите число b: ");
int b = Convert.ToInt32(ReadLine());
if (a > b)
{
    WriteLine($"Число {a} больше числа {b}");
}
else
{
    WriteLine($"Число {b} больше числа {a}");
}
