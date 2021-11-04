public class Program
{
  public static int[] Puzzle(int[] a, int t)
  {
	  for (int i = 0; i < a.Length; i++)
	  {
		  if (a[i] < 0)
		  {
			  if (-a[i] < t)
			  {
				  a[i] = 0;
			  }
		  }
		  else if (a[i] < t)
		  {
			  a[i] = 0;
		  }
	  }
	return a;
  }
}