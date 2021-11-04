public class Program
{

	public static string Puzzle(int n)
	{
		return n < 2 ? "" + n : Puzzle(n / 2) + n % 2;
	}
}