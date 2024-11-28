string s = Console.ReadLine();
char[] charArr = s.ToCharArray();

for (int i = 0; i < s.Length; i++)
{
    if (charArr[i] == ',')
    {
        charArr[i] = ' ';
    }
    else if (charArr[i] >= 'A' && charArr[i] <= 'Z')
    {
        charArr[i] = (char)(charArr[i] - 'A' + 'a');
    }
    else
    {
        charArr[i] = (char)(charArr[i] - 'a' + 'A');
    }

}
Console.WriteLine(charArr);