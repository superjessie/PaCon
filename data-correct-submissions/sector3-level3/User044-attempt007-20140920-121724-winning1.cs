public class Program
{
  public static int Puzzle(int[] a, int k)
  {
int count = 0, i, j, temp;
foreach (int x in a)
{
count++;
}
for (i = 0;i < count - 1;i++)
{
	for (j = i;j < count;j++)
	{
	if (a[i] > a[j])
	{
	temp = a[i];
a[i] = a[j];
a[j] = temp;
	}
	}
}
return a[k];
  }
}