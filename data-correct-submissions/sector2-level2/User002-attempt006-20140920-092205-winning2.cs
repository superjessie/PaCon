using System;
using System.Linq;
public class Program {
  public static int Puzzle(string s) {
	 int x = 0; 
     var f = s.Where(c=>"()".Contains(c)).Select(c=>c=='('?++x:--x);
     return f.Count()==0||f.Last()!=0||f.Any(c=>c<0) ? 0 : f.Max();
  }
}