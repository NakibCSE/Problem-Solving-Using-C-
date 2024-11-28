int n, a, b, c, sa = 0, sb = 0, sc = 0;
n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    a = input[0]; b = input[1]; c = input[2];
    sa = sa + a;
    sb = sb + b;
    sc = sc + c;
}

if (sa == 0 && sb == 0 && sc == 0)
{
    Console.WriteLine("YES");
}
else

{
    Console.WriteLine("NO");
}