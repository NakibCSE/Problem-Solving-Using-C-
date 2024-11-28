int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int a = inputs[0];
int b = inputs[1];

int result = a - b >= 0 ? a - b : 0;
Console.WriteLine(result);