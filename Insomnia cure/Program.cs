//Reading input
int k, l, n, m, d;
k = int.Parse(Console.ReadLine());
l = int.Parse(Console.ReadLine());
m = int.Parse(Console.ReadLine());
n = int.Parse(Console.ReadLine());
d = int.Parse(Console.ReadLine());

if (k == 1 || l == 1 || m == 1 || n == 1)
{
    Console.WriteLine(d);
}
else
{
    int count = 0;
    for (int i = 1; i <= d; i++)
    {
        if (i % k == 0 || i % l == 0 || i % m == 0 || i % n == 0)
        {
            continue;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine(d - count);
}