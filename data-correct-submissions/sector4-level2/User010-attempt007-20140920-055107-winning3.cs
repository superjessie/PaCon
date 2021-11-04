public class Program
{

	public static int Puzzle(int m, int n)
	{
		return fact(m) / fact(n) / fact(m - n);
	}

	private static int fact(int n)
	{
		return n == 0 ? 1 : n * fact(n - 1);
	}
}