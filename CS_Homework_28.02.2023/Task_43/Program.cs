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

const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений y = {lineData1[COEFFICIENT]} * x + {lineData1[CONSTANT]} и y = {lineData2[COEFFICIENT]} * x + {lineData2[CONSTANT]}");
    Console.WriteLine($" имеет координаты ({coord[X_COORD]}, {coord[Y_COORD]})");
}

// Вывод числа
double Prompt(string message)
{
    System.Console.Write(message); // вывести сообщение
    string value = Console.ReadLine(); // считывает с консоли строку
    double result = Convert.ToDouble(value); // преобразует строку в целое число
    return result; // возвращает результат
}

// Вывод данных по прямой
double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[COEFFICIENT] = Prompt($"Введите коэффициент для {numberOfLine} прямой > ");
    lineData[CONSTANT] = Prompt($"Введите константу для {numberOfLine} прямой > ");
    return lineData;
}

// Поиск координат
double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X_COORD] = (lineData2[CONSTANT] - lineData1[CONSTANT]) / (lineData1[COEFFICIENT] - lineData2[COEFFICIENT]);
    coord[Y_COORD] = lineData1[COEFFICIENT] * coord[X_COORD] + lineData1[CONSTANT];
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
    {
        if (lineData1[CONSTANT] == lineData2[CONSTANT])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}
