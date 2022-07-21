void CubeNumbers (int n)
{
    int i = 1;
    while (i <= n)
    {
        Console.WriteLine(Math.Pow(i, 3));
        i += 1;
    }
}

Console.Write("введите число ");
int n = int.Parse(Console.ReadLine());
CubeNumbers(n);