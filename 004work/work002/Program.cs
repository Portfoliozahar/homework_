//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

int sum = 0;
while (a > 0) 
{
    sum += a % 10;
    a /= 10;
}

Console.WriteLine (sum);



int sumnums(int sum)

{
if(sum==0) return 0;
return sumnums (sum/10)+sum%10;

}

Console.WriteLine(sumnums( 123));