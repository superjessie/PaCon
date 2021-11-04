public class Program
{
  public static string Puzzle(int n)
  {
	string @out = "";

		while (n > 1)
		{
			@out = n % 2 + @out;
			n = n / 2;
		}

		if (n >= 0)
		{
			@out = n + @out;
		}

		return @out;
  }
}