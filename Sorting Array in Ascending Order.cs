using System;
using System.Linq;
class array1 {
	public static void Main(string[] args) {
		int i,j,n,temp=0;
		int[] arr = new int[100];
		Console.WriteLine("Enter Number of Element : ");
		n = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter {0} Elements : ",n);
		for(i=0;i<n;i++) {
			arr[i] = int.Parse(Console.ReadLine());
		}
		for(i=0;i<n;i++) {
			Console.Write(arr[i]);
		}
		for(i = 0; i <= n; i++) {
			for(j = i+1; j < n; j++) {
				if(arr[i] > arr[j]) {
					temp = arr[i];
					arr[i] = arr[j];
					arr[j] = temp;
				}
			}
		}
		Console.WriteLine("\nArray After Ascending Sort");
		for(i=0;i<n;i++) {
			Console.Write(arr[i]);
		}
	}
}