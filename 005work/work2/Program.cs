void Print(int[] arr)

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

int sum(int[] arr)
{
    int n = 0;

    for (int i = 0; i < arr.Length; i+=2)
    
        
        {
            n += arr[i];

        }
    
    return n;
}

int[] arr1= Nums(6,1,11);
Print(arr1);
Console.WriteLine(sum(arr1));