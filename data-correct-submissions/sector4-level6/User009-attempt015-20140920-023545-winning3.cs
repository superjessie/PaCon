using System;

public class Program {
  public static string Puzzle(string s)
    {
        var result = String.Empty;
        int n = 0;
        foreach (var c in s)
        {
            var i = (c - 97 + Fib(n)) % 26;
            result += (char)(i + 97);
            n++;
        }


        return result;
    }


    public static int Fib(int n)
    {
        if (n < 2) return 1;
		var result = 1;
		var a = 1;
		var b = 1;
		for (int i =1; i<n; i++)
		{
			result = a+b;
			a = b;
			b = result;
		}
		return result;
    }
}