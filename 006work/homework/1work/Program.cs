 // Напишите программу, которая будет создавать копию заданного массива(вещественные числа) с помощью поэлементного копирования.

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
        arr[i] = Math.Round(n.NextDouble() * (11 + 12) - 10, 2);

    }
    return arr;
}

double[] copy(double[] array)
{
    double[] new_arr = new double[array.Length];
    for (int i = 0; i < new_arr.Length; i++)
    {
        new_arr[i] = array[i];
    }
    return new_arr;
}

double[] array = Nums (5);
Print(array);
Print(copy(array));

