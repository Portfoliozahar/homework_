// Задача 19 Напишите программу, которая принимает на вход пятизначное число  и проверяет, является ли оно палиндромом.



Console.WriteLine("введите пятизначное число и мы ответим палиндром ли оно ");
int n = int.Parse(Console.ReadLine());

if (n > 99999 || n<10000) 
    {
    Console.WriteLine("error ");
    }
else
    {
    int n1 = n / 10000;
    int n2 = (n / 1000) %10;
    int n3 = (n / 100) %10;
    int n4 = (n / 10) %10;
    int n5 = n %10;

    if (n1 == n5 && n2 == n4)
       {
        Console.WriteLine("да");
       } 
    else
        {
            Console.WriteLine("нет");
        }
    }
    