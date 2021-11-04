public class Program
{
  public static string Puzzle(int n)
  {
	  int @in;
	  string st = "";
	 do
	 {
		  @in = n % 2;
		  n /= 2;
		  st += @in.ToString();
	 }while (n != 0);
	  string retval = "";
	  for (int i = st.Length - 1;i >= 0;i--)
	  {
	   retval += st[i];
	  }
	return retval;
  }
}