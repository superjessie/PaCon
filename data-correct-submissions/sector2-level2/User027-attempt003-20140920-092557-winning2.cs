using System;

public class Program {
  public static int Puzzle(string s) {
            int count = 0;
            int maxcount = 0;
            foreach (char c in s)
	        {
                if (c == '(')
                {
                    count++;
                    if (count > maxcount) maxcount = count;
                }
                else if (c == ')') count--;
                if (count < 0) break;
	        }
            if (count != 0) return 0;
            else return maxcount;
  }
}