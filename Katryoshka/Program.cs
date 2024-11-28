
long[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);

long n = inputs[0];
long m = inputs[1];
long k = inputs[2];
long result = 0;

if (n == 0 || k == 0)
{
    Console.WriteLine(0);
}
else
{

    if (n < m && n < k)
    {
        Console.WriteLine(n);
    }
    else if (k < m && k < n)
    {
        Console.WriteLine(k);
    }
    else
    {
        result += m;
        k = k - m;
        n = n - m;
        m = 0;
        n = n / 2;
        if (n <= k)
        {
            result += n;
        }
        else
        {
            result += k;
        }

        Console.WriteLine(result);
    }
}