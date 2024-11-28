using System.Diagnostics.CodeAnalysis;

int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int n = input[0];
int m = input[1];

int[] input2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int currentHouse = 1;
long result = 0;

foreach (int task in input2)
{
    if (task >= currentHouse)
    {
        result += task - currentHouse;
    }
    else
    {
        result += (n - currentHouse) + task;
    }
    currentHouse = task;
}

Console.WriteLine(result);