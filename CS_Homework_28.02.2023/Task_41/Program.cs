// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


// Задаем метод создания массива чисел от пользователя
int[] ReadNumber(string messegeToUser)
{
    Console.Write(messegeToUser);
    int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    return array;
}

// Задаем метод подсчета чисел больше нуля 
int NumbersGreaterZero(int[] UserArray)
{
    int count = 0;
    for (int i = 0; i < UserArray.Length; i++)
    {
        if (UserArray[i] > 0)
        {
            count++;
        }      
    }
    return count;
}

// Запрос информации от пользователя
int[] listOfNumbers = ReadNumber("Введите числа через пробел: ");

// Блок формирования и вывода информации в терминал
int CountNumbersGreaterZero = NumbersGreaterZero(listOfNumbers);
Console.WriteLine($"Количество чисел в массиве, больших нуля: {string.Join(", ", CountNumbersGreaterZero)}");
