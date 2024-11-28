int x = int.Parse(Console.ReadLine());
int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int[] arr = new int[x];
for (int i = 0; i < x; i++)
{
    arr[i] = inputs[i];
}
for (int i = 0; i < x; i++)
{
    if (arr[i] == 1)
    {
        Console.WriteLine("HARD");
        return;
    }
}
Console.WriteLine("EASY");