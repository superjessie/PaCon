public class Program
{
  public static int[] Puzzle(int[] a, int t)
  {
	  for (int i = 0; i < a.Length; i++)
	  {
	  if ((a[i] * a[i] / 2) < (t * t / 2))
	  {
		  a[i] = 0;
	  }
	  }
	return a;
  }
}