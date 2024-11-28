int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int k = inputs[0];
int r = inputs[1];
int count = 1;
while (true)
{
    if ((k * count) % 10 == 0)
    {
        break;
    }
    else if (((k * count) - r) % 10 == 0)
    {
        break;
    }
    count++;
}
Console.WriteLine(count);