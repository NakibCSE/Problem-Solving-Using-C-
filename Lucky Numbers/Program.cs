int input = int.Parse(Console.ReadLine());
int number1 = input % 10;
int number2 = (input / 10) % 10;
if (number1 % number2 == 0 || number2 % number1 == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}