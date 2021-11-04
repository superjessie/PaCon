using System;

public class Program {
  public static int Puzzle(int[] a) {

            if (a.Length > 2)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a.Length - 1; j++)
                    {
                        if (a[j] > a[j + 1])
                        {
                            int temp = a[j];
                            a[j] = a[j + 1];
                            a[j + 1] = temp;
                        }
                    }
                }

                int max = a[a.Length-1];
                int min = a[0];
                //if (a.Length == 20) { return max;}
                return max-min;
            }
            else if (a.Length == 2)
                return a[0] > a[1] ? a[0] - a[1] : a[1] - a[0];

      return 0;


  }
}