    string ChangeNum (int num)
{
    string result = "";
    while (num>0)
    {
        result = num%2 + result;
        num /= 2;
    }
    return result;
}


Console.WriteLine (ChangeNum(575));
