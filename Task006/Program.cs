/*Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка)*/
Console.Clear();
Console.Write("Введите число: ");
double number = double.Parse(Console.ReadLine()!);
if (number % 2 == 0)
{
    Console.WriteLine("Введенное число чётное");
}
else
{
    Console.WriteLine("Введенное число нечётное");
}