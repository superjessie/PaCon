public class Program
{
  public static string Puzzle(int n)
  {

	  string result = "";
	  if (n != 0)
	  {
	  while (n != 1)
	  {
		  result = n % 2 + result;
		  n = n / 2;
	  }
	  result = 1 + result;
	  return result;
	  }
	  return "0";
  }
}