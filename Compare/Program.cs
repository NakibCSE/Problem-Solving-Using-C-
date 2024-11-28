string x = Console.ReadLine();
string y = Console.ReadLine();

int ans = x.CompareTo(y);
if (ans == 0 || ans == -1)
{
    Console.WriteLine(x);
}
else
{
    Console.WriteLine(y);
}