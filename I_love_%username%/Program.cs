//Read the number of contest (n)
int n = int.Parse(Console.ReadLine());

//Read point for n contest
int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

//Set the amazing performance calculator
int mxPoint = input[0];
int mnPoint = input[0];
int AmazingPerformance = 0;

//Travers the input array and calculate the number of amazing performance
for (int i = 1; i < input.Length; i++)
{
    if (mxPoint < input[i])
    {
        mxPoint = input[i];
        AmazingPerformance++;
    }
    if (mnPoint > input[i])
    {
        mnPoint = input[i];
        AmazingPerformance++;
    }
}
Console.WriteLine(AmazingPerformance);