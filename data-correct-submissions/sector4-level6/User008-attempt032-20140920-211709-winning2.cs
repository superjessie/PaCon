public class Program
{

internal static int f(int n)
{
   int prev = 0, next = 1, result = 1;
   for (int i = 1; i < n; i++)
   {
	   result = prev + next;
	   prev = next;
	   next = result;
   }
   return result;
}

public static string Puzzle(string s)
{
string res = "";

for (int i = 0; i < s.Length; ++i)
{
char t = (char)(s[i] + (f(i + 1) % 26));
if (t > 'z')
{
	t -= (char)('z' - 'a' + 1);
}
if (t < 'a')
{
t = (char)('z' - ('a' - t) + 1);
}

res += t;
}
	return res;
}



}
