// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int first_digit = num / 10000;
int second_digit = (num / 1000) % 10;
int fifs_digit = num % 10;
int fors_digit = (num % 100) / 10;
 if (first_digit == fifs_digit && second_digit == fors_digit)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

