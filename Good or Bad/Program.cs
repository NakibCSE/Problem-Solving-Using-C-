int testCase = int.Parse(Console.ReadLine());
while (testCase > 0)
{

    string s = Console.ReadLine();

    if (s.Contains("010") || s.Contains("101"))
    {
        Console.WriteLine("Good");
    }
    else
    {
        Console.WriteLine("Bad");
    }
    testCase--;
}