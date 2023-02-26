// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

// Задаем метод определения суммы элементов, стоящих на нечетных позициях массива
int SumAlementsOddPosition(int[] array)
{
    int sumAlements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sumAlements += array[i];
        }
    }
    return sumAlements;
}

int lengthOfArray = ReadNumber("Задайте длину массива: ");
int leftBorder = ReadNumber("Задайте левую границу случайного диапазона: ");
int rightBorder = ReadNumber("Задайте правую границу случайного диапазона: ");

int[] StandartArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);
Console.WriteLine($"[{string.Join(", ", StandartArray)}]");

int SumAlementsOddIndex = SumAlementsOddPosition(StandartArray);
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях: {SumAlementsOddIndex}");

