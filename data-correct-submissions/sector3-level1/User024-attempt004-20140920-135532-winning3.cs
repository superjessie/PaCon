public class Program
{
  public static int[] Puzzle(int[] a, int t)
  {
	for (int i = 0; i < a.Length; i++)
	{
		a[i] = a[i] < 0 ? -1 * a[i] >= t ? a[i] : 0 : a[i] >= t ? a[i] : 0;
	}

	return a;

  }
}