/*Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.*/
Console.Clear();
Console.Write("Введите число больше единицы: ");
double number = double.Parse(Console.ReadLine()!);
if (number >= 2)
{
    int index = 2;
    Console.Write($"Последовательность чётных чисел от 1 до {number}:");
    while (index <= number)
    {
        if (index % 2 == 0)
        {
            Console.Write($"  {index}");
        }
        index++;
    }
    Console.WriteLine();
}
else if ((number > 1) && (number < 2))
    { 
        Console.WriteLine($"В последовательности чисел от 1 до {number}, чётных чисел нет");
    }
    else
    {
        Console.WriteLine("Введено недопустимое число");
    }