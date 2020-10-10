using System;
namespace LAB_Programs
{
class PP3
{
public static void Main(String[] args)
{
double a, b, c, r1, r2, d;
Console.WriteLine("Enter a , b and c");
a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());
c = double.Parse(Console.ReadLine());
d = b * b - 4 * a * c;
if (d == 0)
{
Console.WriteLine("Equal Roots");
r1 = -b / (2 * a);
r2 = r1;
Console.WriteLine("Root1=" + r1 + "\nRoot2=" +
r2);
}
else if (d > 0)
{
Console.WriteLine("Distinct Roots");
r1 = (-b + Math.Sqrt(d)) / (2 * a);
r2 = (-b - Math.Sqrt(d)) / (2 * a);
Console.WriteLine("Root1=" + r1 + "\nRoot2=" +
r2);
}
else
{
Console.WriteLine("Imaginary Roots");
r1 = -b / (2 * a);
r2 = Math.Sqrt(Math.Abs(d)) / (2 * a);
Console.WriteLine("Root1=" + r1 + "+i" + r2);
Console.WriteLine("Root1=" + r1 + "-i" + r2);
}
}
}
}