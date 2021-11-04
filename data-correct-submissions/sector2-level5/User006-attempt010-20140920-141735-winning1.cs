public class Program
{
  public static int Puzzle(int[] a)
  {
	 int min = a[0], max = a[0];
	for (int i = 1; i < a.Length; i++)
	{
		if (a[i] < min)
		{
			min = a[i];
		}
		if (a[i] > max)
		{
			max = a[i];
		}
	}
	return max - min;
  }
}