int testCase = int.Parse(Console.ReadLine());

while (testCase > 0)
{
    long[] input = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
    long n = input[0];
    long s = input[1];

    long sum = (n * (n + 1) / 2);
    List<long> output = new List<long>();
    if (sum < s)
    {
        Console.WriteLine(-1);
    }
    else
    {
        for (long i = n; i >= 1; i--)
        {
            if (s >= i)
            {
                output.Add(i);
                s -= i;
            }
            if (s == 0)
            {
                break;
            }
        }
        Console.WriteLine(string.Join(" ", output));
    }
    testCase--;
}