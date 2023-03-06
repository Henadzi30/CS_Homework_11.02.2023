// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же
// указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17->такого числа в массиве нет

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

// Метод поиска элемента массива по заданной позиции
int ReturnNumber(int[,] matrix, int searchString, int searchColumn)
{
    int searchNumber = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == searchString - 1 && j == searchColumn - 1)
            {
                searchNumber = matrix[i, j];
            }  
        }
    }
    return searchNumber;
}

// Блок запрашиваемой у пользователя информации
int m = ReadNumber("Введите количество строк: ");
int n = ReadNumber("Введите количество столбцов: ");
int left = ReadNumber("Введите нижний предел случайных чисел: ");
int right = ReadNumber("Введите верхний предел случайных чисел: ");
int searchStringPosition = ReadNumber("Введите номер строки матрицы искомого элемента: ");
int searchColumnPosition = ReadNumber("Введите номер столбца матрицы искомого элемента: ");


// Проверка условия ввода
bool flag = true;
while (flag)
{
    if (searchStringPosition > m | searchColumnPosition > n)
    {
        Console.WriteLine($"Такого числа в массиве нет! Позиции искомого элемента введены не корректно. Попробуйте ввести корректные значения.");
        flag = false;
    }
    else
    {
        // Блок вывода результатов в консоль
        int[,] myMatrix = GetRandomMatrix(m, n, left, right);
        Console.WriteLine();
        PrintMatrix(myMatrix);
        Console.WriteLine();
        Console.Write($"Искомый элемент матрицы: {ReturnNumber(myMatrix, searchStringPosition, searchColumnPosition)}");
        flag = false;
    }
}



