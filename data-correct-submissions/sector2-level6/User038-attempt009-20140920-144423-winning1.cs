using System;

public class Program {
  public static string Puzzle(int n) {if (n==0)
     return "0";
int quot;

        string rem = "";

        while (n >= 1)

        {

            quot =n / 2;

            rem += (n % 2).ToString();

            n= quot;

        }

        string bin = "";

        for (int i = rem.Length - 1; i >= 0; i--)

        {

            bin = bin + rem[i];

        }
    return bin;
  }
}