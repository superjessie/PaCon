public class Program
{
  public static int Puzzle(int[] a, int k)
  {
	  int t;
	  for (int i = 0;i < a.Length - 1;i++)
	  {
		for (int j = i + 1;j < a.Length;j++)
		{
		  if (a[i] > a[j])
		  {
			t = a[i];
			a[i] = a[j];
			a[j] = t;
		  }
		}
	  }
	  return a[k];
  }
}