// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.

Console.Clear();
Console.WriteLine($"Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");

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
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Метод, сортирующий строки массива по убыванию
void SortDescending(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
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
Console.WriteLine("Упорядоченная по строкам матрица");
Console.WriteLine("-----------------");
SortDescending(myMatrix);
PrintMatrix(myMatrix);
Console.WriteLine("-----------------");




// Console.Clear();
// Console.WriteLine($"Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");

