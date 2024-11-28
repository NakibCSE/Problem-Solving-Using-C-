string input = Console.ReadLine();
int count = 0;
HashSet<char> set = new HashSet<char>();
foreach (char ch in input)
{
    if (ch != ',' && ch != '{' && ch != '}' && ch != ' ' && set.Add(ch))
    {
        count++;
    }
    else
    {
        continue;
    }
}
Console.WriteLine(count);