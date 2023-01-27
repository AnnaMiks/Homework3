// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки
//14212 -> нет
//12821 -> да
//23432 -> да

int Prompt(string message)
{
    Console.WriteLine(message + ">");
    return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите пятизначное число");
if (number < 10000 || number > 99999)
{
    Console.WriteLine("Число не пятизначное");
}
else
{

    int a1 = number / 10000;
    int a2 = number % 10;
    int b1 = number / 1000 % 10;
    int b2 = number / 10 % 10;

    if (a1 == a2 && b1 == b2)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}