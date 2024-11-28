using System.Numerics;

BigInteger n = BigInteger.Parse(Console.ReadLine());
BigInteger ans = (n * (n + 1) / 2);
Console.WriteLine(ans);