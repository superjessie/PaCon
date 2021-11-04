public class Program
{
  public static int Puzzle(int[] a)
  {
	int min = 99999, max = -99999;
	for (int i = 0; i < a.Length; i++)
	{
		if (a[i] > max)
		{
		  max = a[i];
		}
		if (a[i] < min)
		{
		  min = a[i];
		}
	}

	return (max - min);
  }
}