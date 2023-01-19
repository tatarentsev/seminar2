// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(number);

int second_number_of_number = (number / 10) % 10;
Console.WriteLine($"Вторая цифра числа {number} -> {second_number_of_number}");