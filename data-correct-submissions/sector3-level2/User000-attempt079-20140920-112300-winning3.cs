public class Program
{
	  public static int Puzzle(int n)
	  {
		return n < 4?n:Puzzle(n - 1) + Puzzle(n - 2);
	  }
}