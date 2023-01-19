// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 & number < 1000)
{
    Console.WriteLine($"Третья цифра числа {number} равна {(number / 10) % 10}");
}

else
{
    if (number > 1000 & number < 10000)
    {
        Console.WriteLine($"Третья цифра числа {number} равна {(number % 100) / 10 }");
    }

    else
    {
        if (number > 10000 & number < 100000)
        {
            Console.WriteLine($"Третья цифра числа {number} равна {(number % 1000) / 100}");
        }

        else
        {
            Console.WriteLine($"У числа {number} третьей цифры нет");
        }
    }
}
