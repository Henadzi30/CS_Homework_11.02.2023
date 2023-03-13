// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n. 

// m = 2, n = 3  -> A(m, n) = 29

// Задаем метод запроса информации от пользователя
uint ReadNumber(string massageToUser)
{
    Console.Write(massageToUser);
    uint value = Convert.ToUInt32(Console.ReadLine());
    return value;
}

// Метод вывода чисел от 1 до N
uint Ackerman(uint M, uint N)
{
    if (M == 0) return N + 1;
    else if ((M != 0) && (N == 0)) return Ackerman(M - 1, 1);
    else return Ackerman(M - 1, Ackerman(M, N - 1));
}

uint numM = ReadNumber("Введите число M: ");
uint numN = ReadNumber("Введите число N: ");
Console.Write($"A({numM}, {numN}) = {Ackerman(numM, numN)}");