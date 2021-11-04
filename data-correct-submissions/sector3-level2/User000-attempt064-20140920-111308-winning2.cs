public class Program
{
  public static int Puzzle(int n)
  {
	  if (n == 0)
	  {
		  return 0;
	  }
	int a = 1, b = 1;
	for (int i = 1;i <= n;a = b + (b = a),i++)
	{
		;
	}
	return b;
  }
}