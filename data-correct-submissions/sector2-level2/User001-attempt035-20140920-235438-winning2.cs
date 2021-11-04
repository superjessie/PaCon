
public class Program {

    public static int Puzzle(string s) {
		int ans = 0;
		int count = 0;
		for (int i = 0; i < s.Length; i++) {
			if (s[i] == '(') {
				++count;
				if (count > ans) ans = count;
			} else if (s[i] == ')') {
				--count;
				if (count < 0) count = 224;
			}
		}
		return count == 0 ? ans : 0;
	}
}
