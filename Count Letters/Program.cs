
string s = Console.ReadLine();

Dictionary<char, int> CountLetters = new Dictionary<char, int>();

foreach (char c in s)
{
    if (CountLetters.ContainsKey(c))
    {
        CountLetters[c]++;
    }
    else
    {
        CountLetters.Add(c, 1);

    }
}

foreach (KeyValuePair<char, int> item in CountLetters.OrderBy(key => key.Key))
{
    Console.WriteLine($"{item.Key} : {item.Value}");
}