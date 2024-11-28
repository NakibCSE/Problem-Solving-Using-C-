string s = Console.ReadLine();
bool isPlaindrome = true;
for (int i = 0, j = s.Length - 1; i < (s.Length / 2) - 1; i++, j--)
{
    if (s[i] != s[j])
    {
        isPlaindrome = false;
        break;
    }
}
if (isPlaindrome)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}