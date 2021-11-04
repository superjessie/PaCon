public class Program
{
  public static string Puzzle(int n)
  {
   int t = n;
int z;
string sa = "";
if (n == 0)
{
	return n.ToString();
}
while (t > 0)
{
z = t % 2;
if (z == 1)
{
sa = "1" + sa;
}
else
{
sa = "0" + sa;
}
t = t / 2;
}
 return sa;
  }
}