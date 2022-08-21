// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j],6} ");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] array = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(from, to);
        }
    }
    return array;
}


void Min(int[,] arr)

{

    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    int amount = 1000;
    int num;
    int small = 0;

    for (int i = 0; i < row_size; i++)

    {
        num = 0;
        for (int j = 0; j < column_size; j++)
            num += arr[i, j];
        Console.Write($"{num,5}");

        if (amount > num)
        {
            amount = num;
            small = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($" Строка с наименьшей суммой элементов - {small + 1}");
    


}

Console.Write("Enter the numbers of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the numbers of columns: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(row, column, 1, 11);
Print(arr_1);
Min(arr_1);
