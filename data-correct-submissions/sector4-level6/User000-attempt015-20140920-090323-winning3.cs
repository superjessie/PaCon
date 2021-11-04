public class Program
{
  public static string Puzzle(string s)
  {
	  string s2 = "";
	  int a = 1, b = 0, c = a + b;
	for (int i = 0;i < s.Length;i++)
	{
			s2 += (char)((s[i] - 'a' + c) % 26 + 'a');
			a = b;
			b = c;
			c = a + b;
	}
	return s2;
  }
}