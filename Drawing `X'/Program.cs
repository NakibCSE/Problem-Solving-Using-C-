int x = int.Parse(Console.ReadLine());
for (int i = 0; i < x; i++)
{
    char[] row = new char[x];
    for (int j = 0; j < x; j++)
    {
        row[j] = '*';
    }
    row[i] = '\\';
    row[x - i - 1] = '/';

    if (i == x / 2)
    {
        row[i] = 'X';
    }
    Console.WriteLine(row);
}