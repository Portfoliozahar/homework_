
void Print(double[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for(int i = 0; i < row_size; i++)
    {
        for(int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j], 6} ");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] MassNums(int row, int column)
{
    double[,] arr = new double[row, column];
    Random n = new Random();
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
            arr[i, j] = Math.Round(n.NextDouble() * (10 + 10) - 0, 0);

        }        
    }
    return arr;    
}


string ChangeRowsWithColumns (double[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if(row != column)
        return "Это невозможно";

    for (int i = 0; i < row; i++)
    {
       for (int j = 0; j < i; j++)
            (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);
    }
    return "Это возможно";
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

double[,] arr_1 = MassNums(row, column);
Print(arr_1);

Console.WriteLine(ChangeRowsWithColumns(arr_1));
Print(arr_1);
