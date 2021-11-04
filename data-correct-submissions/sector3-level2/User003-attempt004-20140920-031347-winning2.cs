public class Program
{
  public static int Puzzle(int n)
  {
	int[] tab = new int[n + 1];
	for (int i = 0;i <= n;i++)
	{
	tab[i] = (i < 4)?i:tab[i - 1] + tab[i - 2];
	}
	return tab[n];
  }
}