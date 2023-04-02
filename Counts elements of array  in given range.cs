using System; 
  
public class GFG  { 
      
    // function to count elements 
    // within given range 
    public static int countInRange(int []arr, int n,  
                            int x, int y) 
    { 
          
        // initialize result 
        int count = 0;
	Console.WriteLine("Counted Elements range from {0} to {1}",x,y);
        for (int i = 0; i < n; i++) { 
            if (arr[i] >= x && arr[i] <= y) 
		count++; 
        } 
        return count;
    } 
  
    // Driver Code 
    public static void Main () 
    { 
        int[]arr = {1,2,12,13,23,27,33,34,35,43,46,49,52,55,57,61,66,67,81,80,70,75,91,98,99}; 
        int n = arr.Length; 
  
        // Answer queries 
        int i = 1, j = 10; 
        Console.WriteLine( countInRange(arr, n, i, j)) ; 
      
        i = 11;
	j = 20; 
        Console.WriteLine( countInRange(arr, n, i, j)) ; 
          
         i = 21;
	j = 30; 
        Console.WriteLine( countInRange(arr, n, i, j)) ;

	i = 31;
	j = 40; 
        Console.WriteLine( countInRange(arr, n, i, j)) ;

	i = 41;
	j = 50; 
        Console.WriteLine( countInRange(arr, n, i, j)) ;

	i = 51;
	j = 60; 
        Console.WriteLine( countInRange(arr, n, i, j)) ;

	i = 61;
	j = 70; 
        Console.WriteLine( countInRange(arr, n, i, j)) ;

	i = 71;
	j = 80; 
        Console.WriteLine( countInRange(arr, n, i, j)) ;

	i = 81;
	j = 90; 
        Console.WriteLine( countInRange(arr, n, i, j)) ;

	i = 91;
	j = 100; 
        Console.WriteLine( countInRange(arr, n, i, j)) ;
    } 
}