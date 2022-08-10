void print(int[] arr)

{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] Nums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {

        arr[i] = new Random().Next(from, to);
    }
    return arr;
}


int evenNum(int[] arr)
{
    int n = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            n += 1;

        }
    }
    return n;
}

int[] arr1= Nums(15,100,300);
print(arr1);
Console.WriteLine(evenNum(arr1));