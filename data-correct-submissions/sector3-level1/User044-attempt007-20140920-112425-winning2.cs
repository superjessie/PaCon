public class Program
{
  public static int[] Puzzle(int[] a, int t)
  {
int i, count = 0;
foreach (int x in a)
{
count++;
}
for (i = 0;i < count;i++)
{
	if (a[i] % t != 0 && a[i] < t && a[i]>-t)
	{
a[i] = 0;
	}
}

	return a;
  }
}