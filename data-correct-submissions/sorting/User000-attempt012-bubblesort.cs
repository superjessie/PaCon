using System;
using System.Collections.Generic;

public static class Program
{
    //The "this" keyword before the method parameter identifies this as a C# extension
    //method, which can be called using instance method syntax on any generic list,
    //without having to modify the generic List<T> code provided by the .NET framework.
    public static int[] Sort(int[] a)
    {
        bool madeChanges;
        int itemCount = a.Length;
        do
        {
            madeChanges = false;
            itemCount--;
            for (int i = 0; i < itemCount; i++)
            {
				if(a[i] > a[i+1])
                {
                    var temp = a[i + 1];
                    a[i + 1] = a[i];
                    a[i] = temp;
                    madeChanges = true;
                }
            }
        } while (madeChanges);
		return a;
    }
}