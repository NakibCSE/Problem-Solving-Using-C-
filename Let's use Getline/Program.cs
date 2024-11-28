using System.Text;

string s = Console.ReadLine();
string ans = "";
//StringBuilder sb = new StringBuilder(s);
foreach (char c in s)
{
    if (c == '\\')
    {
        break;
    }
    ans += c;
}
Console.WriteLine(ans);