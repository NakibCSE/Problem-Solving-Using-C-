int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int n = inputs[0];
int k = inputs[1];

int[] inputsNumber = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
for (int i = 0; i < n; i += k)
{
    int currentMinium = inputsNumber[i];
    for (int j = i; j < i + k && j < n; j++)
    {
        if (inputsNumber[j] < currentMinium)
        {
            currentMinium = inputsNumber[j];
        }
    }
    Console.Write(currentMinium + " ");
}