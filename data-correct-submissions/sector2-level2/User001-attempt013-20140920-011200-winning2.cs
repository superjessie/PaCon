public class Program
{
  public static int Puzzle(string s)
  {
	  int cnt = 0, cnt2 = 0;
	  foreach (char ch in s)
	  {
		  if (ch == '(')
		  {
			  ++cnt;
		  }
		  else if (ch == ')')
		  {
			  --cnt;
		  }
		  if (cnt2 < cnt)
		  {
			  cnt2 = cnt;
		  }
		  if (cnt < 0)
		  {
			  return 0;
		  }
	  }
	  return cnt == 0 ? cnt2 : 0;
  }
}