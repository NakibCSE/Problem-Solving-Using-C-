int n, exit, enter, maxx = 0, cur = 0, a, b;
n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    a = inputs[0];
    b = inputs[1];
    cur = cur - a;
    cur = cur + b;
    maxx = Math.Max(maxx, cur);

}
Console.WriteLine(maxx);