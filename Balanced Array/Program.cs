int x = int.Parse(Console.ReadLine());

for (int i = 0; i < x; i++)
{
    int n = int.Parse(Console.ReadLine());

    // Check if it's possible to construct the array
    if (n % 4 != 0)
    {
        Console.WriteLine("NO");
        continue;
    }

    Console.WriteLine("YES");

    // Construct the array
    int halfLength = n / 2;
    int evenSum = 0;
    for (int j = 1; j <= halfLength; j++)
    {
        Console.Write(j * 2 + " ");
        evenSum += j * 2;
    }
    int oddSum = 0;
    for (int j = 0; j < halfLength - 1; j++)
    {
        Console.Write(j * 2 + 1 + " ");
        oddSum += j * 2 + 1;
    }
    Console.WriteLine(evenSum - oddSum);
}