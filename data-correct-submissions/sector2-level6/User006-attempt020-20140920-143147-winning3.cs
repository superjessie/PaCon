public class Program
{
  public static string Puzzle(int n)
  {
	  if (n == 0)
	  {
	  return "0";
	  }
	string str = "";
	while (n != 0)
	{
		str = (n % 2 == 0)?'0' + str:'1' + str;
		n = n / 2;
	}
	return str;
  }
}