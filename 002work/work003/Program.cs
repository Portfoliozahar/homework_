// Задача 3: Напишите программу, которая выводит третью цифру заданного  числа или сообщает, что третьей цифры нет.
void ThirdNumber (int a)
{
    if (a > -100 && a < 100){
        Console.WriteLine("error");
        return;
    }
    while(a > 1000 || a < -1000){
        a = a / 10;
    }
    Console.WriteLine(a % 10);
}
Console.Write("Write a number  ");
int a = int.Parse(Console.ReadLine());

ThirdNumber(a);