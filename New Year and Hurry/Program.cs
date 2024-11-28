//Read the inputs
int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

//Total time (From contest start to mid night)
int TotalTime = 240;

//Available time to solve problem
int availableTime = TotalTime - input[1];

//Count the number of solved problem
int numberOfSolvedProblem = 0;

for (int i = 1; i <= input[0]; i++)
{
    if (availableTime < (i * 5))
    {
        break;
    }
    else
    {
        availableTime = availableTime - (i * 5);
        numberOfSolvedProblem++;
    }
}

Console.WriteLine(numberOfSolvedProblem);