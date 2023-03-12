// Заполните спирально массив 4 на 4.

// Задача 62: Заполните спирально массив 4 на 4.
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

// Блок задачи данных и создание матрицы
int lengthMatrix = 4;
int[,] spiralMatrix = new int[lengthMatrix, lengthMatrix];

int element = 1;
int i = 0;
int j = 0;

while (element <= lengthMatrix * lengthMatrix)
{
    spiralMatrix[i, j] = element;
    element++;
    if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1) j++;
    else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1) i++;
    else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1) j--;
    else i--;
}

// Метод вывода в консоль спиральной матрицы 
void PrintArray(int[,] matrix)
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

// Вывод результатов в консоль
PrintArray(spiralMatrix);