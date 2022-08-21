int sumnums(int sum)

{
if(sum==0) return 0;
return sumnums (sum/10)+sum%10;

}

Console.WriteLine(sumnums( 123));