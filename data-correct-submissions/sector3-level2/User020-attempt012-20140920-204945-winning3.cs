public class Program
{
  public static int halfFib(int x)
  {
	  if (x <= 3)
	  {
		  return x;
	  }
	  return halfFib(x - 1) + halfFib(x - 2);
  }
  public static int Puzzle(int n)
  {
	return halfFib(n);
  }
}