// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

int ReadNumber(string messageToUser)
{
    Console.Write(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}
double xA = ReadNumber("Введите координату точки А по оси х: ");
double yA = ReadNumber("Введите координату точки А по оси y: ");
double zA = ReadNumber("Введите координату точки А по оси z: ");
double xB = ReadNumber("Введите координату точки B по оси х: ");
double yB = ReadNumber("Введите координату точки B по оси y: ");
double zB = ReadNumber("Введите координату точки B по оси z: ");

// Console.WriteLine("Введите координаты первой точки 'А': ");
// Console.Write("значение по оси 'X': ");
// double xA = Convert.ToDouble(Console.ReadLine());
// Console.Write("значение по оси 'Y': ");
// double yA = Convert.ToDouble(Console.ReadLine());
// Console.Write("значение по оси 'Z': ");
// double zA = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите координаты первой точки 'B': ");
// Console.Write("значение по оси 'X': ");
// double xB = Convert.ToDouble(Console.ReadLine());
// Console.Write("значение по оси 'Y': ");
// double yB = Convert.ToDouble(Console.ReadLine());
// Console.Write("значение по оси 'Z': ");
// double zB = Convert.ToDouble(Console.ReadLine());

double distance = (Math.Sqrt(Math.Pow(xB - xA , 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2)));

Console.WriteLine(Math.Round(distance, 2));
