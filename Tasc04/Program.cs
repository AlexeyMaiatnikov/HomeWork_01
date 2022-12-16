// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
using static System.Console;
Clear();
WriteLine("Введите число N: ");
int Number = Convert.ToInt32(ReadLine());
int Numbers = 1;
if (Number < Numbers) Write("Недопустимое число");
while (Numbers <= Number)
{
    if (Numbers % 2 == 0)
    {
        Write($"{Numbers}, ");
    }
    Numbers++;
}