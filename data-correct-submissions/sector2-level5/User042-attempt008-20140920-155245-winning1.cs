public class Program
{
  public static int Puzzle(int[] a)
  {
	int smallest = a[0], largest = a[0];
	for (int i = 0; i < a.Length; i++)
	{
		if (smallest > a[i])
		{
			smallest = a[i];
		}
		if (largest < a[i])
		{
			largest = a[i];
		}
	}
	return largest - smallest;
  }
}