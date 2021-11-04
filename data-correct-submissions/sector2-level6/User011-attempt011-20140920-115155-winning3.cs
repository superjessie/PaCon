public class Program
{
  public static string Puzzle(int n)
  {
		string res = "";
		do
		{
			if (n % 2 == 1)
			{
				res = '1' + res;
			}
			else
			{
				res = '0' + res;
			}
			n >>= 1;
		} while (n != 0);
		return res;
  }
}