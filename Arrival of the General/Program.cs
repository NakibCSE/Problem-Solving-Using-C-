//Reading input
int n = int.Parse(Console.ReadLine());
int[] Heights = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

//Finding the leftmost max value and it's position 
int MaxValue = Heights[n - 1];
int MaxValuePosition = n - 1;
for (int i = n - 1; i >= 0; i--)
{
    if (MaxValue <= Heights[i])
    {
        MaxValue = Heights[i];
        MaxValuePosition = i;
    }
}

//Finding the rightmost min value and it's position 
int MinValue = Heights[0];
int MinValuePosition = 0;
for (int i = 0; i < n; i++)
{
    if (MinValue >= Heights[i])
    {
        MinValue = Heights[i];
        MinValuePosition = i;
    }
}

if (MinValuePosition > MaxValuePosition)
{
    int seconds = MaxValuePosition + n - MinValuePosition - 1;
    Console.WriteLine(seconds);
}
else
{
    int seconds = MaxValuePosition + n - MinValuePosition - 2;
    Console.WriteLine(seconds);
}