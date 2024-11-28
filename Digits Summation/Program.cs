using System.Numerics;

BigInteger[] inputs = Array.ConvertAll(Console.ReadLine().Split(), BigInteger.Parse);

BigInteger a = inputs[0];
BigInteger b = inputs[1];

BigInteger la = a % 10;
BigInteger lb = b % 10;

BigInteger ans = la + lb;

Console.WriteLine(ans);
