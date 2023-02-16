// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
if (numberOne >= 100)
{
    while (numberOne > 999)
    {
        numberOne = numberOne / 10;
    }
    Console.WriteLine(numberOne % 10);  
}
else
{
    Console.WriteLine("третьей цифры нет");
}
