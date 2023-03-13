// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1.

// N = 5-> "5, 4, 3, 2, 1"
// N = 8-> "8, 7, 6, 5, 4, 3, 2, 1"

// Задаем метод запроса информации от пользователя
int ReadNumber(string massageToUser)
{
    Console.Write(massageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

// Метод вывода чисел от N до 1
void ReverceReturnIntegers(int N, int A)
{
    if (A < 1) return;
    ReverceReturnIntegers(N, A - 1);
    Console.Write($"{(N - A) + 1}, ");
}

int num = ReadNumber("Введите число N, для которого необходимо вывести все натуральные числа от N до 1: ");
int numA = num;
ReverceReturnIntegers(num, numA);

