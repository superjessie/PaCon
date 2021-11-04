using System;

public class Program {
  public static string Puzzle(string s) {
	  char[] x = s.ToCharArray();
	  int f1 = 1, f2 = 1, t;
	  for (int i = 0; i < s.Length; i++) {
		  x[i] = (char)((x[i] - 'a' + f2) % 26 + 'a');
		  t = f1;
		  f1 += f2; f1 %= 26;
		  f2 = t;
	  }
	  return new string(x);
  }
}