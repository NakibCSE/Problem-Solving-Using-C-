int n = int.Parse(Console.ReadLine());
string inp = Console.ReadLine();
int A = 0, D = 0;
for (int i = 0; i < n; i++)
{
    if (inp[i] == 'A')
    {
        A++;
    }
    else if (inp[i] == 'D')
    {
        D++;
    }
}
if (A > D)
{
    Console.WriteLine("Anton");
}
else if (A < D)
{
    Console.WriteLine("Danik");
}
else
{
    Console.WriteLine("Friendship");
}