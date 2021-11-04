public class Program
{
  public static int Puzzle(int n)
  {
	  int a = 1, b = 0, c = a + b;
		for (int i = 0;i < n;i++)
		{
			a = b;
			b = c;
			c = a + b;
		}
		return n == 0?0:c;
  }
}