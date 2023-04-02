using System;
class evenodd {
	public static void Main() {
		int n;
		Console.WriteLine("Enter the Number : ");
		n = Convert.ToInt32(Console.ReadLine());
		if(n%2==0) {
			Console.WriteLine("{0} is Even Number",n);
		}
		else {
			Console.WriteLine("{0} is Odd Number",n);
		}
	}
}