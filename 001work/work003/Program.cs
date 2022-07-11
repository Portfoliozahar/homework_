//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введи 2 числа и я скажу какое из них больше");

        Console.WriteLine("Введи первое число ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введи второе число ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Введи третье число ");
        int c = int.Parse(Console.ReadLine());
        int max=a;
        if(max<b) max=b;
if(max<c) max=c;

Console.WriteLine(max);
       