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
        if (UserArray[i] > 0) count++;      
    }
    return count;
}

// Запрос информации от пользователя
int[] listOfNumbers = ReadNumber("Введите числа через пробел: ");

// Блок формирования и вывода информации в терминал
int CountNumbersGreaterZero = NumbersGreaterZero(listOfNumbers);
Console.WriteLine($"Количество чисел в массиве, больших нуля: {string.Join(", ", CountNumbersGreaterZero)}");

// Вариант эталонного решения
// Считать число с консоли
int Prompt(string message)
{
    System.Console.Write(message); // вывести сообщение
    string value = Console.ReadLine(); // считывает с консоли строку
    int result = Convert.ToInt32(value); // преобразует строку в целое число
    return result; // возвращает результат
}

// Ввести массив
int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i + 1} -й элемент:  ");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int length = Prompt("Введите количество элементов >");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array)}");
