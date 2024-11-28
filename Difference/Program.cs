double[] input = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);

double a = input[0];
double b = input[1];
double c = input[2];
double d = input[3];

double x = (a * b) - (c * d);
Console.WriteLine($"Difference = {x}");