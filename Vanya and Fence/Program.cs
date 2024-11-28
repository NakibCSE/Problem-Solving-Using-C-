int n, h, hcnt = 0;
int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
n = input[0];
h = input[1];

int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

for (int i = 0; i < n; i++)
{

    if (arr[i] > h)
    {
        hcnt++;
    }

}
int ans = hcnt * 2;
ans += (n - hcnt);
Console.WriteLine(ans);