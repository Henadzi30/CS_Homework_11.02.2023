// Напишите программу, которая задаёт массив из 8 элементов и
// выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]

int number = 8; // по условию задачи количество ячеек памяти
int[] array = new int[number]; // Выделение памяти

// Задаем метод считывания данных, вводимых пользователем 
int ReadNumber(string messegeToUser)
{
    Console.WriteLine(messegeToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}


for (int i = 0; i < array.Length; i++)
{
    int sign = ReadNumber("Введите число: ");
    array[i] = sign;
}
// Преобразуем массив в строку и выведем на экран
Console.WriteLine($"[{string.Join(", ", array)}]");
