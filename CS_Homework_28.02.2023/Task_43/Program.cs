// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//  Метод создания переменных на основании данных пользователя

double ReadNumber(string messegeToUser)
{
    Console.Write(messegeToUser);
    double value = Convert.ToInt32(Console.ReadLine());
    return value;
}

// Метод нахождения координат точки пересечения прямых
(double, double) PointIntersectionLines(double numberK1, double numberB1, double numberK2, double numberB2)
{
    double pointCoordinateX = (-numberB2 + numberB1) / (-numberK1 + numberK2);
    double pointCoordinateY = numberK2 * (-numberB2 + numberB1) / (-numberK1 + numberK2) + numberB2;  
    return (pointCoordinateX, pointCoordinateY);
}

// Блок запроса данных от пользователя
double coefficientK1 = ReadNumber("Введите значение k1: ");
double coefficientB1 = ReadNumber("Введите значение b1: ");
double coefficientK2 = ReadNumber("Введите значение k2: ");
double coefficientB2 = ReadNumber("Введите значение b2: ");

// Блок проверки условий
if (coefficientK1 == coefficientK2 && coefficientB1 == coefficientB2)
{
    Console.Write($"По заданным данным прямые совпадают.");
}
else if (coefficientK1 == coefficientK2 && coefficientB1 != coefficientB2)
{
    Console.Write($"По заданным данным прямые параллельны.");
}

// Вывод результатов в терминал
Console.Write("По заданным данным прямые пересекаются в точке с координатами (x, y): ");
Console.WriteLine($"{PointIntersectionLines(coefficientK1, coefficientB1, coefficientK2, coefficientB2)}");