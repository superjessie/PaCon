public class Program
{
  public static int Puzzle(int n)
  {
	  int an1 = 2, an2 = 1;
	  int an = 0;
	  if (n <= 2)
	  {
		  return n;
	  }
	  for (int i = 2;i < n;i++)
	  {
		  an = an1 + an2;
		  an2 = an1;
		  an1 = an;
	  }
	  return an;
  }
}