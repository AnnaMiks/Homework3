// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    Console.WriteLine(message + ">");
    return Convert.ToInt32(Console.ReadLine());
}
int x1 = Prompt("Введите координаты точки А по оси x");
int y1 = Prompt("Введите координаты точки А по оси y");
int z1 = Prompt("Введите координаты точки А по оси z");
int x2 = Prompt("Введите координаты точки В по оси x");
int y2 = Prompt("Введите координаты точки В по оси y");
int z2 = Prompt("Введите координаты точки В по оси z");


double result = Math.Sqrt(Math.Pow((x2 - x1), 2) +
                   Math.Pow((y2 - y1), 2) +
                   Math.Pow((z2 - z1), 2));


Console.WriteLine($"Длина отрезка равна {result}");