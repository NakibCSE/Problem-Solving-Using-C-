long[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);

long n = inputs[0];
long k = inputs[1];
long a = inputs[2];
if ((n * k) % a > 0)
{
    Console.WriteLine("double");
}
else if (((n * k) / a) > 2147483647)
{
    Console.WriteLine("long long");
}
else
{
    Console.WriteLine("int");
}
