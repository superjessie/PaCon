using System;
using System.Text;
using System.Linq;

public class Program {
  public static string Puzzle(int n) {
        if (n == 0 || n == 1)
            return n.ToString();

        StringBuilder b = new StringBuilder();

        while (n / 2 >= 1)
        {
            b.Append(n % 2);
            n /= 2;
        }
        b.Append(1);

        return new string(b.ToString().ToCharArray().Reverse().ToArray());
  }
}