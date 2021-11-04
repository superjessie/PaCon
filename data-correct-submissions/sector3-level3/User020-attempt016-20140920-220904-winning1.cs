public class Program
{
  public static int Puzzle(int[] a, int k)
  {
	int j = 0;
	int tmp = 0;
	for (int i = 0; i < a.Length - 1; i++)
	{
		j = i + 1;
		while (j > 0 && a[j] < a[j - 1])
		{
			tmp = a[j];
			a[j] = a[j - 1];
			a[j - 1] = tmp;
			j--;
		}
	}
	return a[k];
  }
}