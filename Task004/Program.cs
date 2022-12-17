/*Напишите программу, которая принимает на входе 
три числа и выдаёт максимальное из этих чисел.*/
Console.Clear();
double[] massiv = new double[3];
for (int index = 0; index < 3; index++)
{
    int i = index;
    Console.Write($"Введите число № {i + 1}: ");
    massiv [index] = double.Parse(Console.ReadLine()!);
}
double maximum = massiv[0];
for (int index = 1; index < 3; index++)
{
    if (maximum < massiv[index])
    {
        maximum = massiv[index];
    }
}
Console.WriteLine($"Максимальное число равно {maximum}");