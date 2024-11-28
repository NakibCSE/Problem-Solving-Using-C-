int x, sum, a, c, b;
x = int.Parse(Console.ReadLine());
sum = 0;
for (int i = 0; i < x; i++)
{
    int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    a = inputs[0];
    b = inputs[1];
    c = inputs[2];
    if ((a + b + c) >= 2)
    {
        sum += 1;
    }
}
Console.WriteLine(sum);