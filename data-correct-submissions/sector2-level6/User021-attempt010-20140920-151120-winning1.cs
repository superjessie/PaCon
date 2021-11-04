using System.Linq;

public class Program {

    public static string Puzzle(int n) {
        string ss = "";
        int temp = 0;
        if (n == 0) return "0";
        while (n > 0) {
            temp = n % 2;
            ss += temp.ToString();
            n = n / 2;
        }
        return new string(ss.ToCharArray().Reverse().ToArray());
    }
}
