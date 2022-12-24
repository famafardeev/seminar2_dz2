// Задача 1. Написать программу, которая принимает на вход трехзачное число
// и на выходе показывает вторую цифру этого числа. Обязательна проверка на 
// ввод чисел больше/меньше этого числа.

// Console.WriteLine("Введите трехзначное число: ");
// int num = int.Parse(Console.ReadLine()!);

// if (num <= 1000 && num > 100)
// {
//     int resalt = num / 10 % 10;
//     Console.WriteLine($"Вторая цифра числа {num} = {resalt}");
// }
// else{
//     Console.WriteLine($" Вы ввели неправильное число ");
// }

// Задача 2. Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что такой цифры нет. (Берём цифры до 1000000)

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// string Num = Convert.ToString(number);
// if (number < 1000000)
// {
//     Console.WriteLine($"Третья цифра числа {number} = {Num[2]}");
// }
// else
// {
//     Console.WriteLine($" Вы ввели неправильное число ");
// }

// Задача 3. Напишите программу, которая на вход принимает цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// Обязательна проверка на ввод числа <1 и >7

Console.WriteLine("Введите цифру: ");
int number = int.Parse(Console.ReadLine()!);
if (number > 7)
{
    Console.WriteLine($" Неверный день недели ");
}
else
{
    if (number >= 1 && number <=5)
    {
        Console.WriteLine($" Нет ");
    }
    else
    {
        Console.WriteLine($" Да ");  
    }
}









