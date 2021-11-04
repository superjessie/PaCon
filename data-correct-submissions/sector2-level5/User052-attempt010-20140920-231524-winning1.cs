public class Program
{
  public static int Puzzle(int[] a)
  {
	  int max, i, min;
				  max = 0;
			for (i = 0;i < a.Length;i++)
			{
				if (a[i] >= a[max])
				{
					max = i;
				}

			}

			min = 0;
			for (i = 0;i < a.Length;i++)
			{
				if (a[i] <= a[min])
				{
					min = i;
				}

			}

			return (a[max] - a[min]);
//    if(a.length<20)
////		return (a[0]>a[1])?(a[0]-a[1]):(a[1]-a[0]) ;
//		return (a[max]-a[min]);
//	else
//	{
//		for(i=0;i<a.length;i++)
//        	{
//            	if(a[i]<0)
//           	 		return a[min];
//				else
//					return a[max];
//            
//        	}
//	}
//	return 0;
  }
}