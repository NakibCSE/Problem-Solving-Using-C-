long a, b;
long[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
a = inputs[0];
b = inputs[1];


while (b > 0)
{
    if (a % 10 == 0)
        a /= 10;
    else
        a--;
    b--;
}
Console.WriteLine(a);
return 0;