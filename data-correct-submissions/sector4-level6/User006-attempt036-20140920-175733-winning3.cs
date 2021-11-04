public class Program
{
	public static int fib(int n)
	{
		if (n == 1 || n == 2)
		{
			return 1;
		}
		int f1 = 1, f2 = 1, res = 1;
		for (int i = 3; i <= n; i++)
		{
			res = f1 + f2;
			f1 = f2;
			f2 = res;

		}
		return res;
	}
  public static string Puzzle(string s)
  {
	  string tmp = "";
	 for (int i = 0; i < s.Length; i++)
	 {
		 tmp += (char)(97 + ((int)s[i] + fib(i + 1) - 97) % 26);
	 }
	return tmp;
  }
}