using System;
class array1 {
	public static void Main() {
		int i,n,min=0;
		int[] arr = new int[100];
		Console.WriteLine("Enter Number of Element : ");
		n = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter {0} Elements : ",n);
		for(i=0;i<n;i++) {
			arr[i] = int.Parse(Console.ReadLine());
		}
		min = arr[0];
		for(i=1;i<n;i++) {
			if(min > arr[i]) {
				min = arr[i];
			}
		}
		for(i=0;i<n;i++) {
			Console.Write(arr[i]+" ");
		}
		Console.WriteLine("\nMinimum of {0} Elements : {1}",n,min);
	}
}