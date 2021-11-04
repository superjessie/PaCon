public class Program
{
  public static int[] Puzzle(int[] a, int t)
  {
	for (int i = 0;i < a.Length;i++)
	{
		if (a[i] / t < 1 && a[i] / t>-1)
		{
			a[i] = 0;
		}
	}
	return a;
  }
}