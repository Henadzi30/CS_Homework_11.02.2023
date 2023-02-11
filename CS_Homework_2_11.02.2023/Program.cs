// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число а");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число c");
int numberC = Convert.ToInt32(Console.ReadLine());

int max_num = 0;

if (numberA > numberB & numberA > numberC)
{
    max_num = numberA;
}
else if (numberB > numberA & numberB > numberC)
{
    max_num = numberB;
}
else if (numberC > numberA & numberC > numberB)
{
    max_num = numberC;
}
Console.WriteLine(max_num);