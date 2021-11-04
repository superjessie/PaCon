public class Program
{
  public static int Puzzle(int[] a)
  {
	int l, i, max, min;
	l = a.Length;
	max = a[0];
	min = a[0];
	for (i = 1;i < l;i++)
	{
		if (max < a[i])
		{
		max = a[i];
		}
		if (min > a[i])
		{
		min = a[i];
		}
	}
	return (max - min);
  }
}