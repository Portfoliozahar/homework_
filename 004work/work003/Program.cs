//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] arr(int number)
{
    int[] array = new int[number];
    for(int i=0; i < number; i++)
    {
        array[i]=new Random().Next(0, 10);
    }
    return array;
}
arr(8);

void PrintArray (int[] array2)
{
    for(int i=0; i < array2.Length; i++)
        Console.Write($"{array2[i]} ");
}
PrintArray(arr(8));