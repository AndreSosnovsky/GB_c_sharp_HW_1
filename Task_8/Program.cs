Console.Clear();
Console.Write("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());
int notN = 2;
while (notN <= N)
{
    Console.Write(notN);
    Console.Write(", ");
    notN = notN + 2;
} 