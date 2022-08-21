void ValueSetMinMax(int min, int max)
{
    if (max<min) return;
    ValueSetMinMax(min,max-1);
    Console.Write($"{max}, ");
}

ValueSetMinMax(3,10);
