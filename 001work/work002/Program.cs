


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
                Console.WriteLine($" {a} = max");
            }
             else if (n2)
            {
                Console.WriteLine($"Числа {a} и {b} равны");
            }
             else if (n3)
            {
                Console.WriteLine($" {b} = max");
            }