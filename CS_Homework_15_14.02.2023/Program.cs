// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да 
// 7 -> да 
// 1 -> нет


Console.WriteLine("Введите число, обозначающее день недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());
if (1 <= dayNum & dayNum <= 5)
{
    Console.WriteLine("нет");
}
if (dayNum == 6 | dayNum == 7)
{
    Console.WriteLine("да");
}