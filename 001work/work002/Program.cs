//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
        Console.WriteLine("Введи 2 числа и я скажу какое из них больше");

        Console.WriteLine("Введи первое число ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введи второе число ");
        int b = int.Parse(Console.ReadLine());

        bool n1 = a > b;
        bool n2 = a == b;
        bool n3 = a < b;

        if (n1)
            {
                Console.WriteLine($" {a} = max {b} = min");
            }
             else if (n2)
            {
                Console.WriteLine($"Числа {a} и {b} равны");
            }
             else if (n3)
            {
                Console.WriteLine($" {b} = max {a} = min");
            }