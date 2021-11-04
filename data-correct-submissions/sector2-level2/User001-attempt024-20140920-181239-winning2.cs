
using System.Linq;

public class Program {

    public static int Puzzle(string s) {
         string x = new string(s.Where(z => "()".Contains(z)).ToArray());
    	 int c = 0, c1 = 0;
		 foreach (char e in x) {
			 if (e == '(') ++c;
			 else --c;
			 if (c > c1) c1 = c;
			 if (c < 0) return 0;
		 }
		 return c == 0 ? c1 : 0;
	}
}
