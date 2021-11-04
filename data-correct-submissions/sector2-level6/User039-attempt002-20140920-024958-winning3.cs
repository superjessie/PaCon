using System.Text;

public class Program
{
  public static string Puzzle(int n)
  {
	StringBuilder sb = new StringBuilder();
	while (n > 1)
	{
		sb.Insert(0, n % 2);
		n = n >> 1;
	}
	sb.Insert(0, n);
	return sb.ToString();
  }
}