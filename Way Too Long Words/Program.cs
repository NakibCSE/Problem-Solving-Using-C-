int t, len;
string s;
t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    s = Console.ReadLine();
    len = s.Length;
    if (len > 10)
    {
        Console.WriteLine($"{s[0]}{len - 2}{s[len - 1]}");
    }
    else
    {
        Console.WriteLine(s);
    }
}