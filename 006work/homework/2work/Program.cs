void Point(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"точка: x = {x}");
    Console.WriteLine($"точка: y = {y}");
}

Point(6, -7, -2, 9);

