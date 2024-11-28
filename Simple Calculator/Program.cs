double[] input = Array.ConvertAll(Console.ReadLine().Split(" "), double.Parse);
double x = input[0];
double y = input[1];

Console.WriteLine($"{x} + {y} = {x+y}");
Console.WriteLine($"{x} * {y} = {x * y}");
Console.WriteLine($"{x} - {y} = {x - y}");