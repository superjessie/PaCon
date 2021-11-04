public class Program
{



 public static string Puzzle(string s)
 {
	 string res = "";
	 int prev = 0, next = 1, result = 1;

	 for (int i = 0; i < s.Length; ++i)
	 {
		 if (i > 0)
		 {
			 result = prev + next;
			 prev = next;
			 next = result;
		 }
		 char t = (char)(s[i] + (result % 26));
		 if (t > 'z')
		 {
			 t -= (char)('z' - 'a' + 1);
		 }
		 if (t < 'a')
		 {
			 t = (char)('z' - ('a' - t) + 1);
		 }

		res += t;
	 }
	 return res;
 }



}