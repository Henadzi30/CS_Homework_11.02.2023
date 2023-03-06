// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
// элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Метод создания переменных по запрашиваемым у пользователя данным 
int ReadNumber(string massageToUser)
{
    Console.WriteLine(massageToUser);
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
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Блок запрашиваемой у пользователя информации
int m = ReadNumber("Введите количество строк: ");
int n = ReadNumber("Введите количество столбцов: ");
int left = ReadNumber("Введите нижний предел случайных чисел: ");
int right = ReadNumber("Введите верхний предел случайных чисел: ");


// Блок вывода результатов в консоль
int[,] myMatrix = GetRandomMatrix(m, n, left, right);
Console.WriteLine();
PrintMatrix(myMatrix);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: ");

// Блок реализации задачи (вычисления)
for (int j = 0; j < myMatrix.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        avarage += myMatrix[i, j]; 
    }
    avarage /= m;
    Console.Write(avarage + ", ");
}




