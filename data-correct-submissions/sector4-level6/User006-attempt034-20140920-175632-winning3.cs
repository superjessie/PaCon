public class Program
{
	public static int fib(int number)
	{
		if (number == 1 || number == 2)
		{
			return 1;
		}
		int fibo1 = 1, fibo2 = 1, fibonacci = 1;
		for (int i = 3; i <= number; i++)
		{
			fibonacci = fibo1 + fibo2;
			fibo1 = fibo2;
			fibo2 = fibonacci;

		}
		return fibonacci;
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