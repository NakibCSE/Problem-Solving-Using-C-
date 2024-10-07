long n = long.Parse(Console.ReadLine());
long[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);

for (int i = 0; i < n; i++)
{
    long x = inputs[i];
    int cnt = 0;
    while (x % 2 == 0)
    {
        x = x/ 2; 
        cnt++;
    }
    inputs[i] = cnt;
}
Array.Sort(inputs);
Console.WriteLine(inputs[n-1]);