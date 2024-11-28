//Reading input 
int n = int.Parse(Console.ReadLine());
string pangram = Console.ReadLine();

if (n < 26)
{
    Console.WriteLine("NO");
}
else
{
    pangram = pangram.ToLower();
    HashSet<char> list = new HashSet<char>();
    string result = "";
    foreach (char c in pangram)
    {
        if (list.Add(c) && (c >= 'a' && c <= 'z'))
        {
            result += c;
        }
    }

    if (result.Length < 26)
    {
        Console.WriteLine("NO");
    }
    else
    {
        Console.WriteLine("YES");
    }
}