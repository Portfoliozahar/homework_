// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите степень числа: ");
int b = int.Parse(Console.ReadLine());


    int extent = a;
    for(int i = 1; i<b; i++)
    extent = extent * a;
  


Console.WriteLine (extent);


