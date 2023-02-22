// Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Задаем метод считывания числа, вводимого пользователем 
int ReadNumber(string messegeToUser)
{
    Console.WriteLine(messegeToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

// Задаем метод возведения числа А в степень В
int degreeAB( int num_A, int num_B)
{
    int exponintation = 1;
    for(int i = 0; i <= num_B - 1; i++)
    {
        exponintation *= num_A; 
    }
    return exponintation;
}

// Блок запроса информации от пользователя (начало программы) и вывода результата
int number = ReadNumber("Введите число А: ");
int degree = ReadNumber("Введите число B: ");
int result = degreeAB(number, degree);
Console.WriteLine(result);
