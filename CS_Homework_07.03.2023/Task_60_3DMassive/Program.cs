// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Метод создания переменных по запрашиваемым у пользователя данным 
int ReadNumber(string massageToUser)
{
    Console.Write(massageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

// Метод создания трехмерного массива из случайных не повторяющися чисел
void GetRandomMatrix(int[,,] matrix3D)
{
    int[] temporaryVariable = new int[matrix3D.GetLength(0) * matrix3D.GetLength(1) * matrix3D.GetLength(2)];
    int number;
    for (int i = 0; i < temporaryVariable.GetLength(0); i++)
    {
        temporaryVariable[i] = Random.Shared.Next(10, 100);
        number = temporaryVariable[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temporaryVariable[i] == temporaryVariable[j])
                {
                    temporaryVariable[i] = Random.Shared.Next(10, 100);
                    j = 0;
                    number = temporaryVariable[i];
                }
                number = temporaryVariable[i];
            }
        }
    }
    int counter = 0;
    for (int ii = 0; ii < matrix3D.GetLength(0); ii++)
    {
        for (int jj = 0; jj < matrix3D.GetLength(0); jj++)
        {
            for (int kk = 0; kk < matrix3D.GetLength(0); kk++)
            {
                matrix3D[ii, jj, kk] = temporaryVariable[counter];
                counter++;
            }
        }
    }
}

// Метод создания матрицы из массива случайных чисел
void PrintMatrix(int[,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            Console.Write($"X{i} Y{j} ");
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                Console.Write($"Z{k} = {matrix3D[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();        
    }
}

// Блок запрашиваемой у пользователя информации
int value = ReadNumber("Задайте разумный размер трехмерного массива (X, Y, Z), не более 4-х: ");

// Блок вывода результатов в консоль
int[,,] myMatrix3D = new int[value, value, value];
GetRandomMatrix(myMatrix3D);
PrintMatrix(myMatrix3D);

