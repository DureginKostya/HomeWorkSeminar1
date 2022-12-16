/*Напишите программу, которая на вход принимает число и выдает, 
является ли число четным (делится ли оно на два без остатка)*/
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (number % 2 == 0)
{
    Console.WriteLine("Введенное число четное");
}
else
{
    Console.WriteLine("Введенное число нечетное");
}