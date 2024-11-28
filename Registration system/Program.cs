//Read the number of test cases
int TestCase = int.Parse(Console.ReadLine());

//Declare the database (a dictionary)
Dictionary<string, int> Berlandesk = new Dictionary<string, int>();

//Process each test case
while (TestCase > 0)
{
    //Read user name form the user 
    string userName = Console.ReadLine();

    //Check userName already exists in the database
    if (!Berlandesk.ContainsKey(userName))
    {
        Berlandesk[userName] = 0;
        Console.WriteLine("OK");
    }
    else
    {
        int cout = Berlandesk[userName] + 1;
        string newUserName = userName + cout;

        Berlandesk[userName] = cout;
        Berlandesk[newUserName] = 0;

        Console.WriteLine(newUserName);
    }
    TestCase--;
}