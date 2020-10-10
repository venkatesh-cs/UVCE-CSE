using System;
namespace LAB_Programs
{
class Palindrome
{
public static void Main(String[] args)
{
int r, n, rev, m;
Console.WriteLine("Enter the NO:");
n = int.Parse(Console.ReadLine());
m = n;
rev = 0;
while (n != 0)
{
r = n % 10;
rev = rev * 10 + r;
n = n / 10;
}
if (rev == m)
{
Console.WriteLine("its Palindrom");
}
else
{
Console.WriteLine("Not a Palindrom");
}
}
}
}