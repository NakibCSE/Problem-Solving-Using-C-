string s = Console.ReadLine();
int sum = 0;
foreach (char c in s)
{
    sum += c - '0';
}
Console.WriteLine(sum);