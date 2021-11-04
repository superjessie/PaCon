public class Program
{
  public static int Puzzle(int n)
  {
	if (n == 0)
	{
		return n;
	}
	int prevSum = 0, sum = 1, hold;
	for (int i = 0; i < n; i++)
	{
		hold = sum;
		sum += prevSum;
		prevSum = hold;
	}
	return sum;
  }
}