﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.Write("Enter number: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a%2==0)
{
    Console.WriteLine("а is EVEN");
}
else
{
Console.WriteLine("a is ODD");
}
