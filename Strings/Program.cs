using System.Text;

string a = Console.ReadLine();
string b = Console.ReadLine();

int al = a.Length;
int bl = b.Length;

string ab = a + b;

StringBuilder sb = new StringBuilder(a);
StringBuilder sb1 = new StringBuilder(b);
char temp = sb[0];
sb[0] = sb1[0];
sb1[0] = temp;

Console.WriteLine($"{al} {bl}");
Console.WriteLine(ab);
Console.WriteLine($"{sb} {sb1}");
