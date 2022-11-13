//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

double calculateX(double b1, double k1, double b2, double k2)
{
    return (b2 - b1) / (k1 - k2);
}

double calculateY(double b1, double k1, double x)
{
    return k1 * x + b1;
}
Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = calculateX(b1, k1, b2, k2);
double y = calculateY(b1, k1, x);
Console.WriteLine($"({x},{y})");