public class Program
{

	public static string Puzzle(string s)
	{
		int[] fib = new int[50];
		fib[0] = fib[1] = 1;
		for (int i = 2; i < 50; i++)
		{
			fib[i] = fib[i - 1] + fib[i - 2];
		}
		string result = "";
		for (int i = 0; i < s.Length; i++)
		{
			result += (char)((s[i] - 'a' + fib[i]) % 26 + 'a');
		}
		return result;
	}
}