/*Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все четные числа от 1 до N.*/
Console.Clear();
Console.Write("Введите число больше нуля: ");
int number = int.Parse(Console.ReadLine()!);
if (number > 1)
{
    int index = 2;
    Console.Write($"Последовательность четных чисел от 1 до {number}:");
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
else if (number == 1)
    { 
        Console.WriteLine("В последовательности четных чисел нет");
    }
    else
    {
        Console.WriteLine("Введено неправильное число");
    }