// Задайте двумерный массив размером m×n, заполненный случайными
// вещественными числами.

// m = 3, n = 4.
// 0,5 7 - 2 - 0,2
// 1 - 3,3 8 - 9,9
// 8 7,8 - 7,1 9

// Метод создания переменных по запрашиваемым у пользователя данным 
int ReadNumber(string massageToUser)
{
    Console.WriteLine(massageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

// Метод создания массива из случайных чисел
double[,] GetRandomMatrix(int rows, int columns, int numberDigit, int leftBorder, int pointDigit)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((Random.Shared.NextDouble() * numberDigit + leftBorder), pointDigit);
        }
    }
    return matrix;
}

// Метод создания матрицы из массива случайных чисел
void PrintMatrix(double[,] matrix)
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
int digit = ReadNumber("Введите разрядность случайных чисел (десятки - 10, сотни - 100 и т.д.): ");
int pointDigit = ReadNumber("Введите разрядность вещественных чисел после запятой: ");
int left = ReadNumber("Введите нижний предел случайных чисел (число должно быть отрицательным со знаком '-'): ");

// Проверка условия ввода
bool flag = true;
while (flag)
{
    if (left > 0)
    {
        Console.WriteLine($"Значение left не соответсвует требуемым параметрам. Попробуйте ввести корректное значение");
        flag = false;
    }
    else
    {
        // Блок вывода результатов в консоль
        double[,] myMatrix = GetRandomMatrix(m, n, digit, left, pointDigit);
        PrintMatrix(myMatrix);
        flag = false;
    }
}
