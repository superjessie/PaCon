public class Program
{
  public static int Puzzle(int[] a)
  {
	int max = -9999999, min = 99999999;
	for (int i = 0;i < a.Length;i++)
	{
			max = a[i] > max?a[i]:max;
			min = a[i] < min?a[i]:min;
	}
	return max - min;
  }
}