// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number > 999)
{
    number /= 10;
}

if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}

else
{
    Console.WriteLine(number % 10);
}