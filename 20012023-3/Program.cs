Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

int xa, ya, xb, yb, za, zb;
Console.Write("Введите координату Х точки А: ");
while (!int.TryParse(Console.ReadLine(), out xa))
{
    Console.Write("Введен неверный параметр");
}
Console.Write("Введите координату Y точки А: ");
while (!int.TryParse(Console.ReadLine(), out ya))
{
    Console.Write("Введен неверный параметр");
}
Console.Write("Введите координату Z точки А: ");
while (!int.TryParse(Console.ReadLine(), out za))
{
    Console.Write("Введен неверный параметр");
}
Console.Write("Введите координату Х точки B: ");
while (!int.TryParse(Console.ReadLine(), out xb))
{
    Console.Write("Введен неверный параметр");
}
Console.Write("Введите координату Y точки B: ");
while (!int.TryParse(Console.ReadLine(), out yb))
{
    Console.Write("Введен неверный параметр");
}
Console.Write("Введите координату Z точки B: ");
while (!int.TryParse(Console.ReadLine(), out zb))
{
    Console.Write("Введен неверный параметр");
}
double Dist(double xa, double ya, double xb, double yb, double za, double zb)
{
    double result = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
    return result;
}

double res = Dist(xa, ya, xb, yb, za, zb);
Console.WriteLine($"Расстояние между точками А и В в 3D пространстве {Math.Round(res,2)}");

