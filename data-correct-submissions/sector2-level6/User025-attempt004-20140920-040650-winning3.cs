public class Program
{
  public static string Puzzle(int n)
  {
	 if (n == 0)
	 {
		 return "0";
	 }
	string resultado = "";
	while (n > 1)
	{
		if (n % 2 == 0)
		{
			resultado = "0" + resultado;
		}
		else
		{
			resultado = "1" + resultado;
		}
		n /= 2;
	}
	return "1" + resultado;
  }
}