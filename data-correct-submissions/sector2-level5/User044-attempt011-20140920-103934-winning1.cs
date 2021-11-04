public class Program
{
  public static int Puzzle(int[] a)
  {
int count = 0, max, i, min;
min = a[0];
max = a[0];
foreach (int x in a)
{
count++;
}
for (i = 0;i < count;i++)
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
return max - min;

  }
}