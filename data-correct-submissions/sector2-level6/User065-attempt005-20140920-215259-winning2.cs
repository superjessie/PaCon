public class Program
{
  public static string Puzzle(int n)
  {
	  string s = "";
		if (n == 0)
		{
			s = "0";
		}
	while (n > 0)
	{
		if (n % 2 == 1)
		{
			n--;
			s = "1" + s;
		}
		else
		{
			s = "0" + s;
		}
		n = n / 2;
	}
	return s;
  }
}