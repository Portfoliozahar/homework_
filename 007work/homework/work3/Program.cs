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
            arr[i, j] = Math.Round(n.NextDouble() * (10 + 0) - 0, 0);

        }        
    }
    return arr;    

}

void Average (double[,] arr)
{
    for(int j=0; j<arr.GetLength(1); j++)
    {
        double sum = 0;
        for(int i=0; i<arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];
        }
        Console.Write ($" {Math.Round(sum/arr.GetLength(0), 10)} " );
    }
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
double[,] arr_1 = MassNums(row, column);
Print(arr_1);

Average(arr_1);
