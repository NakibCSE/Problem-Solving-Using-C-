int x = int.Parse(Console.ReadLine());
if (x == 0)
{
    Console.WriteLine(0 + " " + 0);
}
else
{
    int[,] input = new int[x, 4];
    int number = 0;
    for (int i = 0; i < x; i++)
    {
        if (i % 2 == 1)
        {
            for (int j = 3; j >= 0; j--)
            {
                input[i, j] = number;

                number++;
            }
        }
        else
        {
            for (int j = 0; j < 4; j++)
            {
                input[i, j] = number;

                number++;
            }
        }

    }

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"({i},{j}) = {input[i, j]} ");
        }
        Console.WriteLine();
    }
}