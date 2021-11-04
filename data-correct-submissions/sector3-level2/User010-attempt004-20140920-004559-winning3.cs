public class Program
{

	public static int Puzzle(int n)
	{
		return n > 2 ? Puzzle(n - 1) + Puzzle(n - 2) : n;
	}
}