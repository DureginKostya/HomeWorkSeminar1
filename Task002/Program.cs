﻿/*Напишите программу, которая на входе принимает два числа 
и выдаёт, какое число больше, а какое меньше.*/
Console.Clear();
Console.Write("Введите первое число: ");
int numberFirst = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int numberSecond = int.Parse(Console.ReadLine()!);
if (numberFirst != numberSecond)
{
    if (numberFirst > numberSecond)
    {
        Console.WriteLine($"Первое число << {numberFirst} >> больше второго числа << {numberSecond} >>");
    }
    else
    {
        Console.WriteLine($"Второе число << {numberSecond} >> больше первого числа << {numberFirst} >>");
    }
}
else
{
    Console.WriteLine("Числа равны");
}