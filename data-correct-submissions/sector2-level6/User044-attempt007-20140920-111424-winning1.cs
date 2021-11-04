public class Program
{
  public static string Puzzle(int n)
  {
int i, y = 1, x, count = 0;
x = n;
string s = "";
if (n == 0)
{
	return "0";
}
if (n == 1)
{
return "1";
}
if (n > 1)
{
	while (x > 1)
	{
	x = x / 2;
count++;
	}
for (i = 0;i < count;i++)
{
y = y * 2;
}
for (i = 0;i <= count;i++)
{
	if (n >= y)
	{
	n = n - y;
y = y / 2;
s = s + "1";
	}
else
{
	s = s + "0";
y = y / 2;
}
}
}
return s;
  }
}