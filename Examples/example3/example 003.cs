// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 6,7,1

Console.Write("Введите цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 5)
{
    Console.WriteLine("да");
}

else
{
    Console.WriteLine("нет");
}