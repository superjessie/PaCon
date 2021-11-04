using System;

public class Program {
  public static int Puzzle(string s) {
	  int max = 0;
	  int level = 0;
	  for (int i = 0; i < s.Length; i++) {
		  if (s[i] == '(') if (++level > max) max = level;
		  if (s[i] == ')') if (--level < 0) return 0;
	  }
	  return level != 0 ? 0 : max;
  }
}