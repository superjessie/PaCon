using System;
using System.Collections.Generic;

public class Program {
    public static int[] Sort (int[] a){
        int temp = 0;
        for (int write = 0; write < a.Length; write++) {
            for (int sort = 0; sort < a.Length - 1; sort++) {
                if (a[sort] > a[sort + 1]) {
                    temp = a[sort + 1];
                    a[sort + 1] = a[sort];
                    a[sort] = temp;
                }
            }
        }
        return a;
    }
}
