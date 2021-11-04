public class Program
{

	public static string Puzzle(int n)
	{
		if (n == 0)
		{
			return "0";
		}
		else
		{
			string result = "";
			while (n > 0)
			{
				result = n % 2 + result;
				n /= 2;
			}
			return result;
		}
	}
}