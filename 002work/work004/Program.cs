// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("введите число  ");
int a = int.Parse(Console.ReadLine());

if (a < 1 || a > 7)
{
    Console.WriteLine("error");
}
else
{
    if (a < 6)
    {
        Console.WriteLine("нет");
    }
    else
    {
        Console.WriteLine("да");
    }
}