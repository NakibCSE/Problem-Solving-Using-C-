int x, sum = 0;
x = int.Parse(Console.ReadLine());

while (x > 0)
{

    sum += x / 5;
    x = x % 5;
    sum += x / 4;
    x = x % 4;
    sum += x / 3;
    x = x % 3;
    sum += x / 2;
    x = x % 2;
    sum += x / 1;
    x = x % 1;
}
Console.WriteLine(sum);