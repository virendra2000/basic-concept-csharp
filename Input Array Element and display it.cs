using System;
class array1 {
	public static void Main() {
		int i,n;
		int[] arr = new int[100];
		Console.WriteLine("Enter Number of Element : ");
		n = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter {0} Elements : ",n);
		for(i=0;i<n;i++) {
			arr[i] = int.Parse(Console.ReadLine());
		}
		for(i=0;i<n;i++) {
			Console.Write(arr[i]+" ");
		}
	}
}