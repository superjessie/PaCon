public class Program
{
  public static string Puzzle(int n)
  {
	int @decimal = n;
	int @base = 2;
	int result = 0;
	int multiplier = 1;
	while (@decimal > 0)
	{
	  int residue = @decimal % @base;
	  @decimal = @decimal / @base;
	  result = result + residue * multiplier;
	  multiplier = multiplier * 10;
	}
	return result + "";
  }
}