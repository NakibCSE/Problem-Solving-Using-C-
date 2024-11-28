using System.Linq.Expressions;
int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int n = inputs[0];
int m = inputs[1];

for (int i = 1; i <= n; i++)
{
    if (i % 4 == 0)
    {
        Console.Write("#");
        for (int j = 1; j < m; j++)
        {
            Console.Write(".");
        }

    }
    else if (i % 2 == 0)
    {
        for (int j = 1; j < m; j++)
        {
            Console.Write(".");
        }
        Console.Write("#");
    }
    else
    {
        for (int j = 1; j <= m; j++)
        {
            Console.Write("#");
        }

    }
    Console.WriteLine();
}