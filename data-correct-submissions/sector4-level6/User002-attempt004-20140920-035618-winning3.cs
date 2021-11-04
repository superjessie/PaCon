using System;
using System.Linq;
using System.Collections.Generic;
public class Program {
  static Dictionary<int,int> fib = new Dictionary<int,int>() {{0,1}, {1,1}};
  static int Fib(int n) {
      if (fib.ContainsKey(n)) return fib[n];
	  fib[n] = Fib(n-1)+Fib(n-2);
      return fib[n];
  }
  public static string Puzzle(string s) {
    return new string(Enumerable.Range(0,s.Length).Select(i=>(char)(97+((int)s[i]-97+Fib(i))%26)).ToArray());
  }
}