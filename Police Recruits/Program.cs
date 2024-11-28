//Read the value of n
int n = int.Parse(Console.ReadLine());
//Read the input array
int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int PoliceMan = 0;
int NumberOfUntratedCase = 0;
for (int i = 0; i < input.Length; i++)
{
    if (input[i] == -1)
    {
        if (PoliceMan == 0)
        {
            NumberOfUntratedCase++;
        }
        else
        {
            PoliceMan--;
        }
    }
    else
    {
        PoliceMan += input[i];
    }
}
Console.WriteLine(NumberOfUntratedCase);