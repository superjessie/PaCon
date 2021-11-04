using System.Text;

public class Program
{
  public static int Puzzle(string s)
  {
	StringBuilder sb = new StringBuilder();
		for (int i = 0; i < s.Length;i++)
		{
			if (s[i] == '(' || s[i] == ')')
			{
				sb.Append(s[i]);
			}
		}

	   s = sb.ToString();
	   int cont = 0;
	   while (s.Contains("()"))
	   {
		   s = s.Replace("()", "");
		   cont++;
	   }
	return (s.Contains("(") || s.Contains(")"))?0:cont;
  }
}