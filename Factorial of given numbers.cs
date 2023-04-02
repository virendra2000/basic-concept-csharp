using System;
class factorial {
	public static void Main() {
		int n;
		Console.WriteLine("Enter a Number");
		n = int.Parse(Console.ReadLine());
		int i,f=1;
		for(i=1;i<=n;i++)  {
			f=f*i;
		}
		Console.WriteLine("Factorial of "+n+" is : "+f);
	}
}