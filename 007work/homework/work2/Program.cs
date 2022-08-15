void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}

string Position (int[,] arr)
{
    Console.WriteLine (" Позиция элемента по горизонтали ");
    int x = int.Parse(Console.ReadLine());

    Console.WriteLine (" Позиция элемента по вертикали  ");
    int y = int.Parse(Console.ReadLine());

    if (arr.GetLength(0) < x || arr.GetLength(1) < y)
    {
        return "Error";
    }
    else 
        return $"Ответ {arr[x-1, y-1]} ";
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 0, 11);
Print(arr_1);

Console.WriteLine (Position(arr_1));