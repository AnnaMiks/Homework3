// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


int Prompt(string message)
{
    Console.WriteLine(message + ">");
    return Convert.ToInt32(Console.ReadLine());
}

int n = Prompt("Введите число");

for (int count = 1; count<=n; count++)
{
    int cube = Convert.ToInt32(Math.Pow(count, 3));
    Console.WriteLine($"{cube}");
}