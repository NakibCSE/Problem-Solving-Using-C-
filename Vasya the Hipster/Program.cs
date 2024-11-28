int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
Array.Sort(inputs);
int differentPair = inputs[0];
int samePair = (inputs[1] - inputs[0]) / 2;
Console.WriteLine($"{differentPair} {samePair}");