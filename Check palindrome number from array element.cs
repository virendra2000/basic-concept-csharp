using System;
class array1 {
	public static int pow(int x,int y) {
		int i,z=1;
		for(i=1;i<=y;i++) {
			z = z * x;
		}
		return z;
	}
	public static void Main() {
		int i,n;
		int num,count=0;
		int[] arr = new int[100];
		Console.WriteLine("Enter Number of Element : ");
		n = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter {0} Elements : ",n);
		for(i=0;i<n;i++) {
			arr[i] = int.Parse(Console.ReadLine());
		}
		armstrng(arr,n);
		
	}
	void armstrng(int a[max],int n) {
        	int i=0, temp, sum=0, rem, c=0;
        	for(i=0; i<n; i++) {
              		sum=0;
              		temp=a[i];
			while(a[i]!=0) {
				a[i] = a[i] / 10;
				c++;
			}
              		while(a[i]!=0)
              		{
                      		rem=a[i]%10;
                      		sum=sum+pow(rem,count);
                      		a[i]=a[i]/10;
               		}
               		if(temp==sum)
               		{
             			Console.WriteLine(sum);
              		}
        }
        
}
}