int[] n = new int[4];
int a, b, c;
n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

Array.Sort(n);


a = n[3] - n[2];
b = n[3] - n[1];
c = n[3] - n[0];

Console.WriteLine($"{a} {b} {c}");