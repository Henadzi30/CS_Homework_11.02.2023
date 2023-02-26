// Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.

// [3 7 22 2 78] -> 76

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

// Задаем метод определения разницы между максимальным и минимальным значениями

int FindMaxDifference(int[] array, int leftBord, int rightBord)
{
    int maxNum = leftBord;
    int minNum = rightBord;
    int difference = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNum)
        {
            maxNum = array[i];
        }
        else if (array[i] < minNum)
        {
            minNum = array[i];
        }
    }
    difference = maxNum - minNum;
    return difference;
}

int lengthOfArray = ReadNumber("Задайте длину массива: ");
int leftBorder = ReadNumber("Задайте левую границу случайного диапазона: ");
int rightBorder = ReadNumber("Задайте правую границу случайного диапазона: ");

int[] StandartArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);
Console.WriteLine($"[{string.Join(", ", StandartArray)}]");

int DifferenceMaxMinElements = FindMaxDifference(StandartArray, leftBorder, rightBorder);
Console.WriteLine($"Разница между максимальным и минимальным значениями массива: {DifferenceMaxMinElements}");

