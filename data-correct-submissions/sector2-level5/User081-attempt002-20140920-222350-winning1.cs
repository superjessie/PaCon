public class Program
{
  public static int Puzzle(int[] a)
  {
	int smallest = a[0];
				int largetst = a[0];

				for (int i = 1; i < a.Length; i++)
				{
						if (a[i] > largetst)
						{
								largetst = a[i];
						}
						else if (a[i] < smallest)
						{
								smallest = a[i];
						}

				}
	return largetst - smallest;
  }
}