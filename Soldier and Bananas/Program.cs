int a, b, c, sum;
int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
a = inputs[0];
b = inputs[1];
c = inputs[2];

sum = a;
for (int i = 2; i <= c; i++)
{
    sum += a * i;
}
int ans = b - sum;
if (ans >= 0)
{
    Console.WriteLine(0);
}

else
{
    Console.WriteLine(sum - b);
}