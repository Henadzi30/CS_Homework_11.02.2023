// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Метод создания переменных по запрашиваемым у пользователя данным 
int ReadNumber(string massageToUser)
{
    Console.Write(massageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

// Метод создания массива из случайных чисел
int[,] GetRandomMatrix(int rows, int columns, int leftBorder, int rightBorder)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1);
        }
    }
    return matrix;
}

// Метод создания матрицы из массива случайных чисел
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// Блок запрашиваемой у пользователя информации
int m = ReadNumber("Введите количество строк массива: ");
int n = ReadNumber("Введите количество столбцов массива: ");
int left = ReadNumber("Введите нижний предел случайных чисел: ");
int right = ReadNumber("Введите верхний предел случайных чисел: ");

// Блок вывода результатов в консоль
int[,] myMatrix = GetRandomMatrix(m, n, left, right);
Console.WriteLine("-----------------");
PrintMatrix(myMatrix);
Console.WriteLine("-----------------");

int minSumRows = 0;
int sumRows = SumElementOfRows(myMatrix, 0);

for (int i = 1; i < myMatrix.GetLength(0); i++)
{
    int tempSumRows = SumElementOfRows(myMatrix, i);
    if (sumRows > tempSumRows)
    {
        sumRows = tempSumRows;
        minSumRows = i;     // номер строки с минимальной суммой элементов
    }
}

// Метод суммирования элементов строки
int SumElementOfRows(int[,] myMatrix, int i)
{
    int sumRows = 0;
    for (int j = 0; j < myMatrix.GetLength(1); j++)
    {
        sumRows += myMatrix[i, j];
    }
    return sumRows;
}

Console.WriteLine($"\n{minSumRows + 1} - строкa с наименьшей суммой элементов, которая равна {sumRows}");
Console.WriteLine("-----------------");


