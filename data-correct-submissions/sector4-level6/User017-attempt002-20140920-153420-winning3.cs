public class Program
{
	public static int getFibonacci(int index)
	{
		int sum = 1, prevSum = 0, hold;
		for (int i = 0; i < index; i++)
		{
			hold = sum;
			sum += prevSum;
			prevSum = hold;
		}
		return sum;
	}
	public static string Puzzle(string s)
	{
		   char[] c = s.ToCharArray();
		for (int i = 0; i < c.Length; i++)
		{
			c[i] = (char)(((int)c[i] - 97 + getFibonacci(i)) % 26 + 97);
		}
		return new string(c);
	}
}