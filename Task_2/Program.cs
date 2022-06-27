// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Enter number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number b ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b)
{
    Console.WriteLine("The Numbers Are Equal");
    return;
}

if (a > b)
{
    Console.WriteLine("Number a max");
}
else
{
    Console.WriteLine("Number b max");
}