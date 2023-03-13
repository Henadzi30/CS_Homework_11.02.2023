// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

// Задаем метод запроса информации от пользователя
int ReadNumber(string massageToUser)
{
    Console.Write(massageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

// Метод вывода чисел от 1 до N
int ReturnIntegers(int M, int N)
{
    if (M == N) return M;
    else return ReturnIntegers(M + 1, N) + M;
}

int numM = ReadNumber("Введите число M: ");
int numN = ReadNumber("Введите число N: ");
Console.WriteLine(ReturnIntegers(numM, numN));