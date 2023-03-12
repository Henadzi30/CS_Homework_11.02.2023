// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
int rowsFirst = ReadNumber("Введите количество строк первого двухмерного массива А: ");
int columnsFirstRowsSecond = ReadNumber("Введите количество столбцов первого двухмерного массива А, также строк второго массива В: ");
int columnsSecond = ReadNumber("Введите количество столбцов второго двухмерного массива В: ");
int left = ReadNumber("Введите нижний предел случайных чисел: "); 
int right = ReadNumber("Введите верхний предел случайных чисел: ");

// Блок вывода результатов в консоль
int[,] firstMatrix = GetRandomMatrix(rowsFirst, columnsFirstRowsSecond, left, right);
int[,] secondMatrix = GetRandomMatrix(columnsFirstRowsSecond, columnsSecond, left, right);

Console.WriteLine("Матрица А");
Console.WriteLine("-----------------");
PrintMatrix(firstMatrix);
Console.WriteLine("-----------------");
Console.WriteLine("Матрица B");
Console.WriteLine("-----------------");
PrintMatrix(secondMatrix);
Console.WriteLine("-----------------");
Console.WriteLine("Результат произведения матрицы А на матрицу B");
Console.WriteLine("-----------------");
int[,] productOfTwoMatrix = new int[rowsFirst, columnsSecond];
MatrixProduct(firstMatrix, secondMatrix, productOfTwoMatrix);
PrintMatrix(productOfTwoMatrix);

void MatrixProduct(int[,] first, int[,] second, int[,] product)
{
    for (int i = 0; i < product.GetLength(0); i++)
    {
        for (int j = 0; j < product.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < first.GetLength(1); k++)
            {
                sum += first[i, k] * second[k, j];
            }
            product[i, j] = sum;
        }
    }
}

