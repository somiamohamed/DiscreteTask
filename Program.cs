Console.WriteLine("enter the first number");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("enter the second number");
int n2 = int.Parse(Console.ReadLine());

int i, j, factor = 0;

Console.WriteLine("Prime numbers from " + n1 + " to " + n2 + " :");

for (i = n1; i <= n2; i++)
{
    if (i == 0 || i == 1)
    {
        continue;
    }
    for (j = 1; j <= i; j++)
    {
        if (i % j == 0)
        {
            factor++;
        }
    }
    if (factor == 2)
    {
        Console.WriteLine(i);
        factor = 0;
    }
    else
    {
        factor = 0;
        continue;
    }
}