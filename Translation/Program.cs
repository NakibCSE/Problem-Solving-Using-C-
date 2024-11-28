string s1 = Console.ReadLine().Trim();
string s2 = Console.ReadLine().Trim();


if (s1.SequenceEqual(s2.Reverse()))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}