public class Program
{
  public static string Puzzle(int n)
  {
if (n == 0)
{
return "0";
}

string s = "";
int rem, i;
while (n != 0)
{
  rem = n % 2;
  s = s + rem;
  n /= 2;
}

string s1 = "";
for (i = s.Length - 1;i >= 0; i--)
{
  s1 = s1 + s[i];
}

	return s1;
  }
}