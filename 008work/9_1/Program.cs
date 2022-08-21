void ValueSet(int num)
{
    if(num == 0) return;
    ValueSet(num - 1);
    Console.Write($"{num}, ");
}

ValueSet(5);
