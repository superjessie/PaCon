using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
class Program  
{  
    public static int[] Sort(int[] a)  
    {   
        int max = a.Length;
        for (int i = 1; i < max; i++)  
        {  
            int j = i;  
            while (j > 0)  
            {  
                if (a[j - 1] > a[j])  
                {  
                    int temp = a[j - 1];  
                    a[j - 1] = a[j];  
                    a[j] = temp;  
                    j--;  
                }  
                else  
                    break;  
            }  
        }  
        return a;  
    }  
}  

