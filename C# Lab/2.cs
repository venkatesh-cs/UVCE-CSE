using System;
namespace LAB_Programs
{
class CommandLine
{
public static void Main(String[] args)
{
int n,f,i,j;
for(i=0;i<args.Length;i++)
{
n=int.Parse(args [i]);
f=1;
for(j=1;j<=n;j++)
{
f=f*j;
}
Console .WriteLine("Factorial of "+n+ " is "
+f);
}
}
}
}