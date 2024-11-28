using System.Collections.Concurrent;

int testCase = int.Parse(Console.ReadLine());
while (testCase > 0)
{
    int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    Array.Sort(inputs);
    if (inputs[0] + inputs[1] == inputs[2])
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
    testCase--;
}