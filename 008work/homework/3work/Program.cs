


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

int[,] Matrix(int[,] arr_first, int[,] arr_second)

{
    int row_size = arr_first.GetLength(0);
    int column_size = arr_first.GetLength(1);
    int[,] pr_matrix = new int[row_size, column_size];

    if (row_size != arr_second.GetLength(0) || column_size != arr_second.GetLength(1)) return pr_matrix;

    for (int i = 0; i < row_size; i++)
        for (int j = 0; j < column_size; j++)
            pr_matrix[i, j] = arr_first[i, j] * arr_second[i, j];
    return pr_matrix;
}


Console.Write("Enter the numbers of rows 1: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the numbers of columns 1: ");
int column = int.Parse(Console.ReadLine());


Console.Write("Enter the numbers of rows 2: ");
int row2 = int.Parse(Console.ReadLine());
Console.Write("Enter the numbers of columns 2: ");
int column2 = int.Parse(Console.ReadLine());




int[,] arr_1 = MassNums(row, column, 1, 11);
Print(arr_1);

int[,] arr_2 = MassNums(row, column, 1, 11);
Print(arr_2);
 
 int[,] Matrixx = Matrix(arr_1,arr_2);
 Print(Matrixx);