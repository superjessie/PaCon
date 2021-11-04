public class Program
{
  public static string Puzzle(string s)
  {
		char[] arr = s.ToCharArray();
		int n1 = 0, n2 = 0, n = 1;
		for (int i = 0;i < arr.Length;i++)
		{
			int t = arr[i] + n % ('z'-'a' + 1);
			n2 = n1;
			n1 = n;
			n = n1 + n2;
			if (t > 'z')
			{
				t = t - 'z'+'a' - 1;
			}
			arr[i] = (char)(t);
		}
		return new string(arr);
  }
}