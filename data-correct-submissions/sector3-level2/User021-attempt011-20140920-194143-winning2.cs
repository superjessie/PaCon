public class Program
{
  public static int Puzzle(int n)
  {
	  if (n <= 3)
	  {
		  return n;
	  }

	  int last = 1;
	  int beforeLast = 1;

	  for (int i = 2; i < n ; i++)
	  {
		  int sub = last;
		  last += beforeLast;
		  beforeLast = sub;
	  }
	return last + beforeLast;
  }
}