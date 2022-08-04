// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите степень числа: ");
int b = int.Parse(Console.ReadLine());


    int extent = a;
    for(int i = 1; i<b; i++)
    extent = extent * a;
  


Console.WriteLine (extent);


