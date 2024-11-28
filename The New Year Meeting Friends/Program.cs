//Read input 
using System.Collections.Immutable;

int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

//Sort the input
Array.Sort(input);

//Calculate the minimum total distance
int distance = (input[1] - input[0]) + (input[2] - input[1]);

//Print the result
Console.WriteLine(distance);