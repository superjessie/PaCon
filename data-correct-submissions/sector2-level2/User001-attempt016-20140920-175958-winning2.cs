


public class Program {

    public static int Puzzle(string s) {
        int c0 = 0, c1 = 0;
		for (int i = 0; i < s.Length; i++) {
			if (s[i] == '(') ++c0;
			else if (s[i] == ')') --c0;
			if (c0 > c1) c1 = c0;
			if (c0 < 0) return 0;
		}
		if (c0 != 0) return 0;
		return c1;
    }
}
