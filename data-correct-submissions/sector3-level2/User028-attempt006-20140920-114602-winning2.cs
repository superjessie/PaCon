public class Program
{
  public static int Puzzle(int n)
  {
	int num1 = 0, num2 = 1, sum = 0;
	for (int i = 1;i <= n;i++)
	{
		sum = num1 + num2;
		num1 = num2;
		num2 = sum;
	}
	return sum;
  }
}