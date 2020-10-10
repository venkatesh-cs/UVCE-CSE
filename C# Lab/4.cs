using System;
namespace LAB_Programs
{
class Box_Unbox
{
public static void Main(String[] args)
{
int m=70;
object o=m; //boxing
try
{
int p=(int)o; //Unboxing;
Console .WriteLine (p);
long q=(long)o;
Console .WriteLine (q);
}
catch (InvalidCastException e)
{
Console .WriteLine ("Unboxing int to different
data type");
}
}
}
}