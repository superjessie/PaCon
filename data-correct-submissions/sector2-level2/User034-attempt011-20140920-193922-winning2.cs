using System;

public class Program
{
    public static int Puzzle(string s)
    {
        int stack = 0, i, c = 0,max=0;
        for (i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                c++;
                stack++;

            }
            else if (s[i] == ')')
            {
                if (stack > max)
                {
                    max = stack;
                }

                stack--;
                if (stack == -1)
                {
                    break;
                }
            }
        }
        return stack == 0 ? max : 0;
    }
}