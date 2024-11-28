int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int k = inputs[0];
int s = inputs[1];
int count = 0;
for (int x = 0; x <= k; x++)
{
    for (int y = 0; y <= k; y++)
    {
        int z = s - x - y;
        if (z >= 0 && z <= k)
        {
            count++;
        }
    }
}
Console.WriteLine(count);