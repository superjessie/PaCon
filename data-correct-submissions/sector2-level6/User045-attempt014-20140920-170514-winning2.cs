public class Program
{
  public static string Puzzle(int n)
  {
		int i = 0;
		string s = "";
		int[] b = new int[25];
		if (n == 0)
		{
			return "0";
		}
		else
		{
		while (n != 0)
		{
			i++;
			b[i] = n % 2;
			n = n / 2;
		}
		for (int j = i; j > 0; j--)
		{
			s = s + b[j].ToString();
		}
		return s;
		}

  }
}