int[] inputFirstLine = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int s = inputFirstLine[0];
int n = inputFirstLine[1];

Tuple<int, int>[] dragons = new Tuple<int, int>[n];

for (int i = 0; i < n; i++)
{
    int[] dragonsInfo = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    int dragonStrength = dragonsInfo[0];
    int bonus = dragonsInfo[1];

    dragons[i] = new Tuple<int, int>(dragonStrength, bonus);
}
Array.Sort(dragons, (x, y) => x.Item1.CompareTo(y.Item1));

foreach (var dragon in dragons)
{
    if (s > dragon.Item1)
    {
        s += dragon.Item2;
    }
    else
    {
        Console.WriteLine("NO");
        return;
    }
}
Console.WriteLine("YES");