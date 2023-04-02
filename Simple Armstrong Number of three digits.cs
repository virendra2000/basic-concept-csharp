using System;
class armstrong {
	public static void Main() {
		int rem,number;
		int res = 0;
		Console.WriteLine("Enter Number to find Armstrong : \n");
		number = int.Parse(Console.ReadLine());
		int temp=number;
		while(number!=0) {
			rem = number%10;
			res = res + rem * rem * rem;
			number = number / 10;
		}
		if(res==temp) {
			Console.WriteLine(temp+" is an Armstrong Number");
		}
		else {
			Console.WriteLine(temp+" is not an Armstrong Number");
		}
	}
}