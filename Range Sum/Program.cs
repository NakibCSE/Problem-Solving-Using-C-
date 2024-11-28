// Read the number of test cases
int testCase = int.Parse(Console.ReadLine());

while (testCase > 0)
{
    // Read l and r values
    long[] input = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
    long l = input[0];
    long r = input[1];

    if (l > r)
    {
        long temp = l;
        l = r;
        r = temp;
    }
    // Calculate the sum from l to r using the sum formula
    long sumR = Sum(r);
    long sumL = Sum(l - 1);

    // Print the result
    Console.WriteLine(sumR - sumL);
    testCase--;

}

// Function to calculate the sum from 1 to n
static long Sum(long n)
{
    return (n * (n + 1)) / 2;
}