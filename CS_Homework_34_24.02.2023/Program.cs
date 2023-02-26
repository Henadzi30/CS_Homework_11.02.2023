// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Задаем метод считывания числа, вводимого пользователем 
int ReadNumber(string messegeToUser)
{
    Console.WriteLine(messegeToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

// Задаем метод создания произвольного массива заданной длины
int[] GetRandomArray(int length, int leftBorder, int rightBorder)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftBorder, rightBorder + 1);
    }
    return array;
}

// Задаем метод определения четности элементов массива
int IsIvenNomber(int[] array)
{
    int amountNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            amountNumbers += 1;
        }
    }
    return amountNumbers;
}

int lengthOfArray = ReadNumber("Задайте длину массива: ");
int leftBorder = 100;
int rightBorder = 999;

int[] StandartArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);
Console.WriteLine($"[{string.Join(", ", StandartArray)}]");

int AmountOfNumbers = IsIvenNomber(StandartArray);
Console.WriteLine($"Количество четных элементов в массиве: {AmountOfNumbers}");
