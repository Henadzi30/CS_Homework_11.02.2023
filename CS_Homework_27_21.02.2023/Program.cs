// Напишите программу, которая принимает на вход число и
// выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Задаем метод считывания числа, вводимого пользователем 
int ReadNumber(string messegeToUser)
{
    Console.WriteLine(messegeToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

// Определяем метод суммирования цифр числа, заданного пользователем
int sumDigitOfNumber(int num)
{
    int sumDigit = 0;
    for(int i = 0; i < num; i++)
    {
        sumDigit += num % 10;
        num /= 10;
    }
    return sumDigit;
}

// Блок запроса информации от пользователя (начало программы) и вывода результата
int number = ReadNumber("Введите число: ");
int result = sumDigitOfNumber(number);
Console.WriteLine(result);
