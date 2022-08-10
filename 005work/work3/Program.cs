void Print(double[] arr)

{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] Nums(int size)

{
    double[] arr = new double[size];
    Random n = new Random();

    for (int i = 1; i < size; i++)
    {
        arr[i] = Math.Round(n.NextDouble() * (10 + 12) - 10, 2);

    }
    return arr;
}

void diff(double[] arr)
{
    double max = arr[0];
    double min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];

        }
        else if (min > arr[i])
        {
            min = arr[i];
        }
    }
    Console.WriteLine($"max: {max} and min {min}");
    Console.WriteLine($"difference: {max}-{min})={Math.Round(max - min, 2)}");
}

double[]arr1= Nums(15);
Print(arr1);
diff(arr1);