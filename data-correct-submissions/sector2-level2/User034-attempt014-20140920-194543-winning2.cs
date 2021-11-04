using System;

public class Program
{
    public static int Puzzle(string s)
    {
        int stack = 0, i, max = 0;
        for (i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
                stack++;
            else if (s[i] == ')')
            {
                if (stack > max)
                    max = stack;
                if (--stack < 0)
                    return 0;
            }
        }
        return stack == 0 ? max : 0;
    }
}