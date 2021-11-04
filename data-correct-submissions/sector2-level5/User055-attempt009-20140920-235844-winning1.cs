public class Program
{
  public static int Puzzle(int[] a)
  {
	int i;
	int h = a[0], l = a[1];
	for (i = 0; i < a.Length; i++)
	{
		if (a[i] > h)
		{
			h = a[i];
		}
		if (a[i] < l)
		{
			l = a[i];
		}

	}
	return h - l;
  }
}