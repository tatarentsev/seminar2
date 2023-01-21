// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 6,7,1

Console.Write("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

string DayOfWeek(int arg1)
{
    string result = "";
    if (arg1 > 0 & arg1 <= 5) result = "нет";
    if (arg1 > 5 & arg1 < 8) result = "да";
    return result;
}

string day = DayOfWeek(number);
Console.Write(day);