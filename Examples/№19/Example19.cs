// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число, а я проверю является ли оно палиндромом: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] & number[1] == number[3]) 
    {
        Console.Write("да");
    }

    else
    {
        Console.Write("нет");
    }
}