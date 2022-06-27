// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Enter number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number b ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number c: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > a)
    max = b;
if (c > max)
    max = c;
Console.WriteLine("Maximum is ");
Console.WriteLine(max);