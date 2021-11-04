public class Program
{
  public static int Puzzle(string s)
  {
	  int counter = 0;
	  int max = 0;
	  for (int i = 0; i < s.Length; i++)
	  {
		  if (s[i] == '(')
		  {
			  counter++;
			  if (counter > max)
			  {
				  max++;
			  }
		  }
		  else
		  {
			 if (s[i] == ')')
			 {
					counter--;
				  if (counter < 0)
				  {
					  return 0;
				  }
			 }
		  }
	  }
	return counter == 0 ? max : 0;
  }
}