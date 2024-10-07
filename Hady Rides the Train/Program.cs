
    long x = long.Parse(Console.ReadLine());

    long row = x / 4;
    long col;

    if (row % 2 == 0)
    {
        col = x % 4;
    }
    else
    {
        col = 3 - (x % 4);
    }
    Console.WriteLine($"{row} {col}");
