// Задайте значения M и N. Напишите программу,
// которая выведет все чётные натуральные числа
// в промежутке от M до N.


void Num(double M, double N)
{
    N -= N % 2;
    if (N < M) return;
    Num(M, N - 2);
    Console.Write($"{N}, ");
}
Num(-5,6);